using System.Windows.Input;

namespace RecordBook.Commands
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Excute {  get; set; }
        private Predicate<object> _CanExcute {  get; set; }

        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {
            _Excute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;
        }

        // 명령이 호출될 때 실행할 수 있는 메서드
        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        // 실행 메서드
        public void Execute(object? parameter)
        {
            _Excute(parameter);
        }
    }
}
