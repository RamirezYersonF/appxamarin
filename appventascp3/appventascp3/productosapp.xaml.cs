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
    public partial class productosapp : ContentPage
    {
        public productosapp()
        {
            InitializeComponent();
        }

        private async void dineropagos_Clicked(object sender, EventArgs e)
        {
            {
                string nombreproductos = nombreproducto.Text;
                double precios = Int32.Parse(precio.Text);
                string nombreproductos2 = nombreproducto.Text;
                double precios2 = Int32.Parse(precio.Text);



                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.52.246/" +
                    "api/Producto?nombreproducto=" + nombreproductos + "&precio=" + precios);


                if (result)
                {
                    //await Navigation.PushAsync(new login());
                    App.Current.MainPage = new metodopago();
                    Console.WriteLine("MainPage");

                }

            }
        }

        private void metodopagoapp_Clicked(object sender, EventArgs e)
        {

        }

     
    }
}
      