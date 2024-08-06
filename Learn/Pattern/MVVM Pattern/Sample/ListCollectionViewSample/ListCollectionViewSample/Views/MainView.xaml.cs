using ListCollectionViewSample.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace ListCollectionViewSample.Views
{
    public partial class MainView : Window
    {
        // 컬렉션의 정렬, 필터링, 탐색 기능을 구현가능하도록 지원
        public ListCollectionView MyCollectionView;

        public Emp emp;

        public MainView()
        {
            InitializeComponent();
        }

        private void rootElement_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // StackPanel의 DataContext로 지정된 emps 컬렉션을 소스로 해서 ListCollectionView 생성
            // 이를 이용하여 정렬, 탐색, 필터링 기능 등을 구현한다.
            // 현재 화면에 떠 있는 데이터 전부 -> 데이터 바인딩 소스 객체 -> EmpViewModel에서 만든 사원들 -> MyCollectionView에 할당
            MyCollectionView = (ListCollectionView)CollectionViewSource.GetDefaultView(rootElement.DataContext);
        }

        // 리스트박스 상단의 정렬 기능 처리
        private void OnClick(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;

            MyCollectionView.SortDescriptions.Clear();

            switch(b.Name)
            {
                case "BtnEmpno":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Empno", ListSortDirection.Ascending));
                    break;
                case "BtnEname":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Ename", ListSortDirection.Ascending));
                    break;
                case "BtnJob":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Job", ListSortDirection.Ascending));
                    break;
            }
        }

        // Previous, Next 버튼 처리
        private void OnMove(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            switch(b.Name)
            {
                case "Previous":
                    if (MyCollectionView.MoveCurrentToPrevious())
                        emp = MyCollectionView.CurrentAddItem as Emp;
                    else
                        MyCollectionView.MoveCurrentToFirst();
                    break;
                case "Next":
                    if (MyCollectionView.MoveCurrentToNext())
                        emp = MyCollectionView.CurrentAddItem as Emp;
                    else
                        MyCollectionView.MoveCurrentToLast();
                    break;
            }
        }

        // 필터링 가능, 관리자만 또는 관리자가 아닌 사원 리스트 출력
        private void OnFilter(object sender, RoutedEventArgs e)
        {
            // 토글 기능 구현
            switch(MyCollectionView.Filter)
            {
                // Filter 델리게이트는 보여줄 데이터인지 아닌지 판단할 수 있는 메소드 참조 > Filter 는 델리게이트.
                case null: MyCollectionView.Filter = IsManager; break;  //관리자만
                default: MyCollectionView.Filter = null; break;         //전체사원
            }
        }

        private bool IsManager(object o)
        {
            var e = o as Emp;
            return e?.Job == "Manager";
        }
    }
}
