using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App14
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();

            Button button = new Button { Text = "Continuar", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, FontSize = 18};

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new pago());
            };

            Content = new StackLayout
            {
                Padding = new Thickness(10, 20, 10, 10),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    new Label{Text = "Check, please.", FontSize = 50 },
                    new Label{Text = "Ingrese el numero de personas", FontSize = 30 },
                    new Entry{Text = "", FontSize = 30 },
                    button
                }

            };





        }

    }
}