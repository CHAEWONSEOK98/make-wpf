using System.Windows;
using System.Windows.Input;

namespace WpfCommand
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Command 사용자 입력 처리
         * 처리하는 입력 > 버튼 클릭과 같은 UI와의 상호 작용부터 키보드 및 마우스 입력까지 다양
         * 이벤트 핸들러로 구현했을 때와 비교하면, 이벤트 핸들러가 키보드, 마우스 입력을 각각 구현해야 한다면 Command는 이를 줄일 수 있다.
         */


        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var obj = e.Parameter as string;
            MessageBox.Show(obj);

            //MainWindow window = new MainWindow();
            //window.Show();
        }
    }
}