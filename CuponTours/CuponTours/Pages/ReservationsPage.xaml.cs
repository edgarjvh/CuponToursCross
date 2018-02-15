using CuponTours.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CuponTours.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReservationsPage : ContentPage
	{
        NavigationService navigationService;

		public ReservationsPage ()
		{
			InitializeComponent ();

            navigationService = new NavigationService();

            this.btnSubmit.Clicked += BtnSubmit_Clicked;

		}

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            var txtName = this.txtName.Text;
            var txtEmail = this.txtEmail.Text;
            var txtDestination1 = this.txtDestination1.Text;
            var txtDestination2 = this.txtDestination2.Text;
            var txtDestination3 = this.txtDestination3.Text;

            if (string.IsNullOrEmpty(txtName))
            {
                await DisplayAlert("Mensaje", "Debe insertar el nombre del titular", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail))
            {
                await DisplayAlert("Mensaje", "Debe insertar el correo electrónico del titular", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtDestination1))
            {
                await DisplayAlert("Mensaje", "Debe insertar al menos un destino", "Aceptar");
                return;
            }


            await ShowMessage("Dialog Title", "Prompt", "Ok", async () =>
            {
                await App.Navigator.PopToRootAsync();
            });
        }

        public async Task ShowMessage(string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await DisplayAlert(
                title,
                message,
                buttonText);

            afterHideCallback?.Invoke();
        }
    }
}