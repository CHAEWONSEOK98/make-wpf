using CommandSample1.Commands;
using CommandSample1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommandSample1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Emp _SelectedEmp;
		public Emp SelectedEmp
		{
			get { return _SelectedEmp; }
			set 
			{
				_SelectedEmp = value;
				OnPropertyChanged();
			}
		}

        public RelayCommand AddEmpCommand { get; set; }

        public ObservableCollection<Emp> Emps { get; set; }

        public MainViewModel()
        {
            Emps = new ObservableCollection<Emp>();
            Emps.Add(new Emp { Ename = "채일", Job = "개발자" });
            Emps.Add(new Emp { Ename = "채이", Job = "연구원" });
            Emps.Add(new Emp { Ename = "채삼", Job = "운동선수" });
            Emps.Add(new Emp { Ename = "채사", Job = "과학자" });
            Emps.Add(new Emp { Ename = "채오", Job = "수학자" });

            // AddEmpCommand = new RelayCommand(new Action<object>(AddEmp)); 이 코드 또는 아래 코드 선택하여 사용 가능
            AddEmpCommand = new RelayCommand(AddEmp);
        }

        public void AddEmp(object parameter)
        {
            Emps.Add(new Emp { Ename = parameter.ToString(), Job = "New Job" });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string Pname = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Pname));
		}
    }
}
