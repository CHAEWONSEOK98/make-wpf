using System.Windows.Input;


namespace CommandSample1.Commands
{
    public class RelayCommand : ICommand
    {
        // 지역변수, 델리게이트
        Func<object, bool> canExecute;
        Action<object> executeAction;

        // 생성자
        public RelayCommand(Action<object> executeAction) : this(executeAction, null)
        {
            
        }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.executeAction = executeAction ?? throw new ArgumentNullException("Execute Action was null");
            this.canExecute = canExecute; // 이 예제에서는 Null
        }

        /*
         * CanExecute 메소드는 명령을 사용 가능하게 하거나 사용 불가능하게 할 때 WPF에 의해 호출
         * 지금 예제와 같은 사용자 정의 명령의 경우 CanExecute 메서드가 알아서 호출되지 않는다
         * 그래서 CanExecuteChanged 이벤트를 CommandManager의 RequerySuggested 이벤트에 연결해야 한다.
         */
        public bool CanExecute(object? parameter)
        {
            // 사원 이름을 입력하지 않으면 Add 버튼은 비활성화 된다.
            if (parameter?.ToString().Length == 0) return false;

            // canExecute는 Func 델리게이트이고 본 예제에서는 NULL로 넘어온다.
            // 그러므로 result는 true가 리턴된다.
            bool result = this.canExecute == null ? true : this.canExecute.Invoke(parameter);
            return result;
        }

        // 실제 실행될 명령은 executeAction 델리게이트가 참조하고 있는 MainViewModel의 AddEmp 메소드이다.
        public void Execute(object? parameter)
        {
            this.executeAction(parameter);
        }

        /*
         * CanExecuteChanged 이벤트를 CommandManager의 RequerySuggested 이벤트에 연결하면
         * CanExecute 메소드가 호출되어 CanExecute의 상태가 변경되고 이때
         * CanExecuteChanged 이벤트가 발생하고 WPF는 CanExecute를 호출하고
         * Command에 연결된 컨트롤의 상태를 변경한다.
         */
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
