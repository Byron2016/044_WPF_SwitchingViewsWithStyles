using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchingViewsWithStyles.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        // controla la navegación entre los viewModels
        private BaseViewModel _selectedViewModel = new HomeViewModel();

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value; }
        }
    }
}
