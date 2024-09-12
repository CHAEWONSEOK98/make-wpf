namespace WpfExplorer.Support.Local.Models
{
    public class LocationChangedEventArgs : EventArgs
    {
        public FileInfoBase Current { get; init; }

        public LocationChangedEventArgs(FileInfoBase current)
        {
            Current = current;
        }
    }
}
