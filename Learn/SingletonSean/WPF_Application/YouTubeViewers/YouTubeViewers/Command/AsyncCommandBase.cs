namespace YouTubeViewers.Command
{
    public abstract class AsyncCommandBase : CommandBase
    {
        public override async void Execute(object? parameter)
        {
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception ex) { }
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
