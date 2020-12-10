using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POCMobileXam.ViewModels
{
    public class SubPageViewModel : ViewModelBase
    {
        public SubPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Sub Page";
            BindTest = "Bind Test Value";
        }

        private string _bindTest;
        public string BindTest
        {
            get { return _bindTest; }
            set { SetProperty(ref _bindTest, value); }
        }
    }
}
