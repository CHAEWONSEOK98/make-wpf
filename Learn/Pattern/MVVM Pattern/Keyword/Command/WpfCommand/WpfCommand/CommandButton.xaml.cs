using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace WpfCommand
{
    public partial class CommandButton : UserControl, ICommandSource
    {
        public CommandButton()
        {
            InitializeComponent();

            MouseLeftButtonDown += CommandButton_MouseLeftButtonDown; // 버튼 클릭 이벤트가 발생할 때마다
        }

        private void CommandButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) // 이벤트 핸들러 실행
        {
            if(Command != null)
            {
                // CanExecute의 매개변수가 이벤트 핸들러에서 사용될 수 있으므로 매개변수를 전달
                // 사용자가 CommandParameter로 지정한 내용을 전달하는 역할
                // 지금 해당 명령을 실행할 수 있는지 확인 > 실행할 수 있는지 확인하려면 CommandParameter를 전달해야함
                if (Command.CanExecute(CommandParameter)) 
                {
                    Command.Execute(CommandParameter);
                }
            }
        }

        public ICommand Command { get; set;}

        public object CommandParameter { get; set;}

        public IInputElement CommandTarget { get; set;}
    }
}
