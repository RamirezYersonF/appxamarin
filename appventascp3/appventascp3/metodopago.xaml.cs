using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appventascp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class metodopago : ContentPage
    {
        public metodopago()
        {
            InitializeComponent();
        }
    

        private async  void detallescompra_Clicked(object sender, EventArgs e)
        {
                string numerocuenta = numerocuentas.Text;
                string nombretarjeta = Banco.Text;

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.52.246/" +
                    "api/Banco?numerocuenta=" + numerocuenta + "&nombretarjeta=" + nombretarjeta);

                if (result)
                {
                    await DisplayAlert("Datos Guardados", "Registro Exitoso", "ok");


                    //await Navigation.PushAsync(new login());
                    App.Current.MainPage = new detallecompra();
                    Console.WriteLine("MainPage");

                }

            }
        }
    
}