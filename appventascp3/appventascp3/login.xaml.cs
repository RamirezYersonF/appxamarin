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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async  void productosapp_Clicked(object sender, EventArgs e)
        {
            string correo = correos.Text;
            string contraseña = contraseñas.Text;

            WSClient client = new WSClient();
            var result = await client.Get<Models.Usuario>("https://192.168.52.246/" +
                "api/Registro?usuario=" + correo + "&contraseña=" + contraseña);
            string h = string.Empty;

            if (result != null)
            {
                if (result.contraseña == contraseña)
                {
                    App.Current.MainPage = new productosapp();
                    Console.WriteLine("MainPage");

                }

                else
                {
                    await DisplayAlert("Error", "Datos incorrectos", "OK");
                }
            }
            //if (result != null)
            //{
            //    Entcont.Text = $"{result.correo}";
            //    Entcont.Text = result.contraseña


            //}

        }
    }

}
    
