using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using SkiaSharp;
using Avalonia.Skia;
using Avalonia.Interactivity;

namespace lab1
{
    public partial class MainWindow : Window
    {
        private Func<double, double> selectedFunction;

        public MainWindow()
        {
            InitializeComponent();
            selectedFunction = Math.Sin; // По умолчанию sin(x)
            this.PointerWheelChanged += OnPointerWheelChanged;
        }

        // Метод для отрисовки графика
        private void DrawGraph(SKCanvas canvas, int width, int height)
        {
            canvas.Clear(SKColors.White);

            using (var paint = new SKPaint())
            {
                paint.Color = SKColors.Black;
                paint.IsAntialias = true;
                paint.StrokeWidth = 2;

                double step = 0.01;
                double scaleX = width / (2.0 * Math.PI);
                double scaleY = height / 2.0;

                for (double x = -Math.PI; x < Math.PI; x += step)
                {
                    double y = selectedFunction(x);
                    double nextY = selectedFunction(x + step);
                    
                    float startX = (float)(x * scaleX + width / 2);
                    float startY = (float)(-y * scaleY + height / 2);
                    float endX = (float)((x + step) * scaleX + width / 2);
                    float endY = (float)(-nextY * scaleY + height / 2);

                    canvas.DrawLine(startX, startY, endX, endY, paint);
                }
            }
        }

        // Метод для смены функции
        private void ChangeFunction(string functionName)
        {
            switch (functionName)
            {
                case "sin(x)":
                    selectedFunction = Math.Sin;
                    break;
                case "x^2":
                    selectedFunction = x => x * x;
                    break;
                default:
                    selectedFunction = Math.Sin;
                    break;
            }

            this.InvalidateVisual();
        }

        // Логика для масштабирования при изменении размера окна
        private void OnPointerWheelChanged(object? sender, PointerWheelEventArgs e)
        {
            // Логика увеличения/уменьшения масштаба
        }

        // Метод для вывода графика в консоль
        private void DrawGraphInConsole()
        {
            int width = 60;
            int height = 20;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double graphX = (x - width / 2.0) / (width / (2.0 * Math.PI));
                    double graphY = selectedFunction(graphX);
                    int graphYPos = (int)((-graphY + 1) * (height / 2.0));

                    if (graphYPos == y)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        // Метод обработки события при выборе функции из ComboBox
        private void OnFunctionSelected(object? sender, SelectionChangedEventArgs e)
        {
            if (functionComboBox.SelectedItem is ComboBoxItem item)
            {
                // Получаем название выбранной функции и передаем его в метод для смены функции
                ChangeFunction(item.Content.ToString());
            }
        }

        // Метод обработки события нажатия кнопки для вывода графика в консоль
        private void OnConsoleButtonClick(object? sender, RoutedEventArgs e)
        {
            // Вызываем метод для вывода графика в консоль
            DrawGraphInConsole();
        }
    }
}
