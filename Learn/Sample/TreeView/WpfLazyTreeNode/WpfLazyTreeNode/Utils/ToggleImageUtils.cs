using System.Windows.Media.Imaging;

namespace WpfLazyTreeNode.Utils
{
    public static class ToggleImageUtils
    {
        static BitmapImage GetBitmapImageByFileName(string fileName)
        {
            return new BitmapImage(new Uri($"./../Images/{fileName}", UriKind.Relative));
        }

        public static (BitmapImage? opendedImage, BitmapImage? closedImage) GetExplorers(ExplorerType explorerType)
        {
            BitmapImage? opendedImage = null;
            BitmapImage? closedImage = null;

            switch (explorerType)
            {
                case ExplorerType.Drive:
                    opendedImage = null;
                    closedImage = GetBitmapImageByFileName("drive.png");
                    break;
                case ExplorerType.Directory:
                    opendedImage = GetBitmapImageByFileName("folder-closed.png");
                    closedImage = GetBitmapImageByFileName("folder-open.png");
                    break;
                case ExplorerType.File:
                    opendedImage = null;
                    closedImage = GetBitmapImageByFileName("file.png");
                    break;

            }

            return (opendedImage, closedImage);
        }
    }

    public enum ExplorerType
    {
        Drive, Directory, File
    }
}
