﻿using System.Windows.Input;

namespace MvvmSample1.Commands
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;

        public RelayCommand(Action<object> excutionAction)
        {
            _executeAction = excutionAction;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => _executeAction(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
    }
}
