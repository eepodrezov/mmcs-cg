using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task2
{
    public partial class Task2Window : Window
    {
        public Task2Window(Bitmap bitmap)
        {
            InitializeComponent();
            Task2Image.Source = bitmap;
        }
    }
}
