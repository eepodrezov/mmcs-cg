using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task3
{
    public partial class Task3Window : Window
    {
        public Task3Window(Bitmap bitmap)
        {
            InitializeComponent();
            Task3Image.Source = bitmap;
        }
    }
}
