using HideNaviBar.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideNaviBar.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _hideCommand;
        public DelegateCommand HideCommand =>
            _hideCommand ?? (_hideCommand = new DelegateCommand(ExecuteHideCommand));

        void ExecuteHideCommand()
        {
            Xamarin.Forms.DependencyService.Get<INaviBarService>().HideNaviBar();
        }

        private DelegateCommand _visibleCommand;
        public DelegateCommand VisibleCommand =>
            _visibleCommand ?? (_visibleCommand = new DelegateCommand(ExecuteVisibleCommand));

        void ExecuteVisibleCommand()
        {
            Xamarin.Forms.DependencyService.Get<INaviBarService>().VisibleNaviBar();
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
