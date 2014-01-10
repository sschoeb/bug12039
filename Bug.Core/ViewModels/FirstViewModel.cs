using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace Bug.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel(DatabaseService databaseService)
        {
            LoadCommand = new MvxCommand(() => databaseService.GetAll<DemoModel>());
        }

        public ICommand LoadCommand { get; set; }
    }
}
