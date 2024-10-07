using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task3
{
    public partial class Task3Window : Window
    {
        // Конструктор по умолчанию для XAML загрузчика
        public Task3Window()
        {
            InitializeComponent();
        }

        // Конструктор с параметром Bitmap
        public Task3Window(Bitmap bitmap) : this() // Вызов конструктора по умолчанию
        {
            Task3Image.Source = bitmap;
        }
    }
}