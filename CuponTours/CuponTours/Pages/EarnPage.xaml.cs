using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using CuponTours.Services;
using System.Collections.Generic;

namespace CuponTours.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EarnPage : ContentPage
	{
        public List<Referral> Referrals { get; set; }
        public EarnPage ()
		{
			InitializeComponent ();

            Referrals = new List<Referral>();
            btnAdd.Clicked += BtnAdd_Clicked;
            btnSubmit.Clicked += BtnSubmit_Clicked;
		}

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            if (Referrals.Count < 5)
            {
                await DisplayAlert("Campo vacío", "Debe ingresar mínimo 5 referidos", "OK");
                return;
            }

            await ShowMessage("Los referidos han sido enviados exitosamente", "Enviados", "Ok", async () =>
            {
                await App.Navigator.PopToRootAsync();
            });

        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                await DisplayAlert("Campo vacío", "Debe ingresar el correo electrónico", "OK");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                await DisplayAlert("Campo vacío", "Debe ingresar el nombre", "OK");
                return;
            }                   
            
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                await DisplayAlert("Campo vacío", "Debe ingresar el número de teléfono", "OK");
                return;
            }

            for (int i = 0; i < Referrals.Count; i++)
            {
                if (Referrals[i].Email == txtEmail.Text)
                {
                    await DisplayAlert("Campo vacío", "El correo electrónico ya existe en la lista", "OK");
                    return;
                }
            }            

            int count = referralList.Children.Count;

            Label lblTest = new Label
            {
                Text = (count + 1)  + "  " + txtName.Text,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            Referrals.Add(
                new Referral
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text
                }
            );

            referralList.Children.Add(lblTest);            
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

    public class Referral
    {        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}