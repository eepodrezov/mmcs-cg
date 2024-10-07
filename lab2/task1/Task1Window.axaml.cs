using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task1
{
    public partial class Task1Window : Window
    {
        // Конструктор по умолчанию для XAML загрузчика
        public Task1Window()
        {
            InitializeComponent();
        }

        // Конструктор с параметром Bitmap
        public Task1Window(Bitmap bitmap) : this() // Вызов конструктора по умолчанию
        {
            Task1Image.Source = bitmap;
        }
    }
}
