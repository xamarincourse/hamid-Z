using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlightList : ContentPage
	{
		public FlightList()
		{
			InitializeComponent ();
            this.BindingContext = new List<Flight>()
            {
                new Flight()
                {
                    getCity="Paris",
                    getSTA="14:20",
                    getETA="14:35",
                    getTerminal="T3",
                    getStatus2="Arrived"
                },
                new Flight()
                {
                    getCity="London",
                    getSTA="14:20",
                    getETA="14:45",
                    getTerminal="T3",
                    getStatus2="Arrived"
                },
                new Flight()
                {
                    getCity="Dubia",
                    getSTA="14:10",
                    getETA="14:35",
                    getTerminal="T2",
                    getStatus2="Delayed"
                }

            };
        }
	}

    public class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (value == "Delayed")
            {
                return Color.Red;
            }
            else
                return Color.Green;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}