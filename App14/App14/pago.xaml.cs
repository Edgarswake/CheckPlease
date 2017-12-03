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
    public partial class pago : ContentPage
    {
        public pago()
        {
            InitializeComponent();
            var pagar = new Label { Text = "Total Gastado", FontSize = 20 };
            var cervezas = new Entry { Text = "Precio total de: ", FontSize = 15 };
            var totalCervezas = new Entry { Text = "Ingresa el monto", FontSize = 15};
            var text = totalCervezas.Text;
            var entradas = new Entry { Text = "Precio total de: ", FontSize = 15 };
            var totalEntradas = new Entry { Text = "Ingresa el monto", FontSize = 15 };
            var text3 = totalEntradas.Text;
            var hamburguesas = new Entry { Text = "Precio total de: ", FontSize = 15 };
            var totalHamburguesas = new Entry { Text = "Ingresa el monto",  FontSize = 15 };
            var text2 = totalHamburguesas.Text;
            String totalChido;
            Label precioTotal = new Label { FontSize = 15};
            Label montoTotal = new Label { FontSize = 15};
            Label montoPersona = new Label { FontSize = 15};
            Label montoPromedio = new Label { FontSize = 15};

            Button promedio = new Button {Text = "Calcular!" };
            promedio.Clicked +=promedio_clic;
            void promedio_clic(object sender, EventArgs e)
            {
                totalChido = text + text2 + text3;
                precioTotal.Text = "Precio Total:";
                montoTotal.Text = "150";
                montoPersona.Text = "Monto por persona:";
                montoPromedio.Text = "37.5";
            }

            Content = new StackLayout
            {
                Padding = new Thickness(10, 20, 10, 10),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    cervezas,
                    totalCervezas,
                    entradas,
                    totalEntradas,
                    hamburguesas,
                    totalHamburguesas,
                    pagar,
                    promedio,
                    precioTotal,
                    montoTotal,
                    montoPersona,
                    montoPromedio,
        }

            };


        }
    }
}