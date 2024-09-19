using Lab11.Models;
using Lab11.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab11.ViewModels
{
    class MainViewModel : BindableBase
    {
        private PageManager _pageManager;

        public MainViewModel()
        {
            _pageManager = new PageManager(new EnterPage());
        }

        public Page CurrentPage
        {
            get { return _pageManager.CurrentPage; }
            set
            {
                _pageManager.CurrentPage = value;
                RaisePropertyChanged(nameof(CurrentPage));
            }
        }

        private DelegateCommand enterCommand;
        public ICommand EnterCommand => enterCommand ??= new DelegateCommand(Enter);

        private void Enter()
        {
            _pageManager.SetCurrentPage(new EnterPage());
            RaisePropertyChanged(nameof(CurrentPage));
        }

    }
}
