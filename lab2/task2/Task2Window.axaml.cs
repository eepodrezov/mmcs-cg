using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task2
{
    public partial class Task2Window : Window
    {
        // Конструктор по умолчанию для XAML загрузчика
        public Task2Window()
        {
            InitializeComponent();
        }

        // Конструктор с параметром Bitmap
        public Task2Window(Bitmap bitmap) : this() // Вызов конструктора по умолчанию
        {
            Task2Image.Source = bitmap;
        }
    }
}