using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{


        public SecondPage ()
		{
			InitializeComponent ();
            var Parvaz = new Flight()
            {
                getArv = "SFO",
                getDep = "LAX",
                getTerm = "1",
                getGate = "A5",
                getSeat = "5A",
                getDepart = "1:00PM",
                getStatus="On Time"

        };
            

            this.BindingContext = Parvaz;

        }
        async void OnButtonTest(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FlightList());
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FlightList());
        }
    }
}