using CuponTours.Pages;
using CuponTours.Services;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace CuponTours.ViewModels
{
    public class MenuItemViewModel
    {
        NavigationService navigationService;

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        public ICommand NavigateCommand {
            get { return new RelayCommand(() => navigationService.Navigate(PageName)); }
        }

        
    }
}
