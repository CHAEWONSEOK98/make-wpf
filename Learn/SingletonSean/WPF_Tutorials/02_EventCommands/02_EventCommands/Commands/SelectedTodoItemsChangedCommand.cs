using System.Windows.Input;

namespace _02_EventCommands.Commands
{
    public class SelectedTodoItemsChangedCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
        }
    }
}
