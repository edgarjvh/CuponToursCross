using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CuponTours.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EarnPage : ContentPage
	{
		public EarnPage ()
		{
			InitializeComponent ();

            btnAdd.Clicked += BtnAdd_Clicked;
            
		}

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            int count = referralList.Children.Count;

            Label lblTest = new Label
            {
                Text = "Etiqueta Num " + (count + 1),
                TextColor = Color.Black
            };

            referralList.Children.Add(lblTest);

            Grid refItem = new Grid {
                
            };
        }
    }
}