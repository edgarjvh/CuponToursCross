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
	public partial class HotelsPage : ContentPage
	{
		public HotelsPage ()
		{
			InitializeComponent ();
            loadHotels();
		}

        private void loadHotels()
        {

            

            for (int i = 0; i < 15; i++)
            {
                int col = i % 2 > 0 ? 1 : 0;
                int row = i / 2;

                gridHotels.Children.Add(
                    new Button
                    {
                        Text = "Hotel " + (i + 1),
                        TextColor = Color.White,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        WidthRequest = 150,
                        HeightRequest = 150,
                        BorderRadius = 10,
                        BorderColor = (Color)Application.Current.Resources["AccentColor1"],
                        BorderWidth = 8,
                        BackgroundColor = (Color)Application.Current.Resources["MainColor"],
                        FontAttributes = FontAttributes.Bold
                    }, col, row
                );
            }            
        }
    }
}