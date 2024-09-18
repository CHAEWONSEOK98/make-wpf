using System.Windows.Input;

namespace _03_AsyncCommands.Commands
{
    public abstract class AsyncCommandBase : ICommand
    {
        private readonly Action<Exception> _onException;

        private bool _isExecuting;
        public bool IsExcuting
        {
            get
            {
                return _isExecuting;
            }
            set
            {
                _isExecuting = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler? CanExecuteChanged;

        protected AsyncCommandBase(Action<Exception> onException)
        {
            _onException = onException;
        }

        public bool CanExecute(object? parameter)
        {
            return !IsExcuting;
        }

        public async void Execute(object? parameter)
        {
            IsExcuting = true;
            try
            {
                await ExecuteAsync(parameter);
            }
            catch(Exception ex)
            {
                _onException?.Invoke(ex);
            }
            IsExcuting = false;
        }

        protected abstract Task ExecuteAsync(object? parameter);
    }
}
