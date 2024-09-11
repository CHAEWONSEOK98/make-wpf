using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System.Windows;
using System.Windows.Input;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        public List<FolderInfo> Roots { get; init; }

        /*
         * ViewModel에서 Roots는 바인딩을 해야 하니까 OnPropertyChanged 필요한데 지금 단계에서는 생성자에서 바로 만들어지므로 DataContext에 연결될 때 같이 바인딩 된다.
         * 이 시점에서는 굳이 OnPropertyChanged 만들지 않아도 된다. 나중에 다른 시점에 객체 변화 -> set 변화가 일어날 때는 OnPropertyChanged 필요.
         * 이번 경우에는 OnPropertyChanged 없이 바인딩됨.
         */

        public MainContentViewModel(FileService fileService)
        {
            Roots = fileService.GenerateRootNodes();
        }

        [RelayCommand]
        private void FolderChanged(FolderInfo item)
        {
            MessageBox.Show(item.Name);
        }
    }
}
