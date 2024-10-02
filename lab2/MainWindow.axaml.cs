using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ImageProcessingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // Выводим сообщение через Debug
            System.Diagnostics.Debug.WriteLine("Open");

            // Либо обновляем интерфейс
            FileNameText.Text = "Open";

            // // Используем стандартный OpenFileDialog
            // var openFileDialog = new OpenFileDialog
            // {
            //     AllowMultiple = false,
            //     Filters = new List<FileDialogFilter>
            //     {
            //         new FileDialogFilter
            //         {
            //             Name = "Image Files",
            //             Extensions = new List<string> { "jpg", "png", "bmp" }
            //         }
            //     }
            // };

            // // Показываем диалоговое окно
            // string[]? result = await openFileDialog.ShowAsync(this);
            
            // if (result != null && result.Length > 0)
            // {
            //     string filePath = result[0];
            //     string fileName = Path.GetFileName(filePath);

            //     // Вместо Console используем Debug или обновляем UI
            //     System.Diagnostics.Debug.WriteLine($"Loaded file: {fileName}");
                
            //     // Обновляем текстовый блок
            //     FileNameText.Text = $"Loaded file: {fileName}";
            // }
        }
    }
}
