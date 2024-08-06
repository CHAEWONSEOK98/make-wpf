using ListCollectionViewSample.Models;
using System.Collections.ObjectModel;


namespace ListCollectionViewSample.ViewModels
{
    public class EmpViewModel : ObservableCollection<Emp>
    {
        public EmpViewModel()
        {
            Add(new Emp() { Empno = 1, Ename = "채일", Job = "개발자" });
            Add(new Emp() { Empno = 2, Ename = "채이", Job = "여행가" });
            Add(new Emp() { Empno = 3, Ename = "채삼", Job = "탐험가" });
            Add(new Emp() { Empno = 4, Ename = "채사", Job = "Manager" });
        }
    }
}
