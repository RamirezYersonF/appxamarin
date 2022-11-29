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

        private async void dineropagos_Clicked1(object sender, EventArgs e)
        {
            {
                string nombreproductos1 = nombreproducto1.Text;
                double precios1 = Int32.Parse(precio1.Text);
             
                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.105.246/" +
                    "api/Producto?nombreproducto=" + nombreproductos1  + "&precio=" + precios1);
            }
        }
        private async void dineropagos_Clicked2(object sender, EventArgs e)
        {
            {
                
                string nombreproductos2 = nombreproducto2.Text;
                double precios2 = Int32.Parse(precio2.Text);

                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.105.246/" +
                     "api/Producto?nombreproducto=" + nombreproductos2 + "&precio=" + precios2);



      }
        }

        private void continuarpagos_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new metodopago();
            Console.WriteLine("MainPage");
        }
    }
}
      