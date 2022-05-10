using SwitchingViewsWithStyles.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwitchingViewsWithStyles.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        // controla la navegación entre los viewModels
        //private BaseViewModel _selectedViewModel = new HomeViewModel();

        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { 
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }


        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);

        }
    }
}
