using CuponTours.Pages;
using CuponTours.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CuponTours.ViewModels
{
    public class MainViewModel
    {
        NavigationService navigationService;
        public MainViewModel()
        {
            navigationService = new NavigationService();
            LoadMenu();
        }

        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Commands
        public ICommand GoToCommand {

            get { return new RelayCommand<string>(GoTo);  }
        }
        #endregion

        #region Methods
        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel()
                {
                    Icon = "menu_icon_home.png",
                    Title = "Inicio",
                    PageName = "MainPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_gallery.png",
                    Title = "Galería",
                    PageName = "GalleryPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_earn.png",
                    Title = "Refiere y Gana",
                    PageName = "EarnPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_share.png",
                    Title = "Comparte",
                    PageName = "SharePage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_alerts.png",
                    Title = "Alertas",
                    PageName = "AlertsPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_follow_us.png",
                    Title = "Síguenos",
                    PageName = "FollowUsPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_destinations.png",
                    Title = "Destinos",
                    PageName = "DestinationsPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_chat.png",
                    Title = "Chat Online",
                    PageName = "ChatPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_comments.png",
                    Title = "Comentarios",
                    PageName = "CommentsPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_videos.png",
                    Title = "Videos",
                    PageName = "VideosPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_restaurant.png",
                    Title = "Restaurantes",
                    PageName = "RestaurantPage"
                },

                new MenuItemViewModel()
                {
                    Icon = "menu_icon_translator.png",
                    Title = "Traductor",
                    PageName = "TranslatorPage"
                }
            };

        } 
        #endregion
    }
}
