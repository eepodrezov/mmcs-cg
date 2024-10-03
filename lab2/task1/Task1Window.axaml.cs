using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace ImageLoaderApp.task1
{
    public partial class Task1Window : Window
    {
        public Task1Window(Bitmap bitmap)
        {
            InitializeComponent();
            Task1Image.Source = bitmap;
        }
    }
}
