using CuponTours.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CuponTours.Services
{
    public class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                case "GalleryPage":
                    await Navigate(new GalleryPage());
                    break;
                case "EarnPage":
                    await Navigate(new EarnPage());
                    break;
                case "SharePage":
                    await Navigate(new SharePage());
                    break;
                case "AlertsPage":
                    await Navigate(new AlertsPage());
                    break;
                case "FollowUsPage":
                    await Navigate(new FollowUsPage());
                    break;
                case "DestinationsPage":
                    await Navigate(new DestinationsPage());
                    break;
                case "ChatPage":
                    await Navigate(new ChatPage());
                    break;
                case "CommentsPage":
                    await Navigate(new CommentsPage());
                    break;
                case "VideosPage":
                    await Navigate(new VideosPage());
                    break;
                case "RestaurantPage":
                    await Navigate(new RestaurantPage());
                    break;
                case "TranslatorPage":
                    await Navigate(new TranslatorPage());
                    break;
                case "AboutPage":
                    await Navigate(new AboutPage());
                    break;
                case "ReservationsPage":
                    await Navigate(new ReservationsPage());
                    break;
                default:
                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atras"); //iOS
            

            await App.Navigator.PushAsync(page);
        }
    }
}
