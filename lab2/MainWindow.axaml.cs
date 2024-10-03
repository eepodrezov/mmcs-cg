using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform.Storage;
using System.IO;
using System.Threading.Tasks;

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
    }
}
