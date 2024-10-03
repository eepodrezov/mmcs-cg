using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform.Storage;
using System.IO;
using System.Threading.Tasks;
using ImageLoaderApp.task1; 
using ImageLoaderApp.task2;
using ImageLoaderApp.task3;

namespace ImageLoaderApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnLoadImageClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (this.StorageProvider != null)
            {
                var file = await OpenImageFileAsync();
                if (file != null)
                {
                    var filePath = file.Path.LocalPath;

                    // Отображение названия файла
                    FileNameTextBlock.Text = Path.GetFileName(filePath);

                    // Загрузка и отображение изображения
                    var bitmap = new Bitmap(filePath);
                    ImageControl.Source = bitmap;

                    // Отображаем кнопки
                    Task1Button.IsVisible = true;
                    Task2Button.IsVisible = true;
                    Task3Button.IsVisible = true;
                }
            }
        }


        private async Task<IStorageFile?> OpenImageFileAsync()
        {
            var filePickerResult = await StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                AllowMultiple = false,
                FileTypeFilter = new[] { new FilePickerFileType("JPEG files") { Patterns = new[] { "*.jpg", "*.jpeg" } } }
            });

            return filePickerResult.Count > 0 ? filePickerResult[0] : null;
        }

        private void OnTask1Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var task1Window = new Task1Window((Bitmap)ImageControl.Source); 
            task1Window.Show();
        }

        private void OnTask2Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var task2Window = new Task2Window((Bitmap)ImageControl.Source);
            task2Window.Show();
        }

        private void OnTask3Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var task3Window = new Task3Window((Bitmap)ImageControl.Source); 
            task3Window.Show();
        }

    }
}
