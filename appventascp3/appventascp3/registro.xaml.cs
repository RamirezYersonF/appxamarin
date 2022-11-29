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
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();
        }

    
        private async void login_Clicked_1(object sender, EventArgs e)
        {
            {
                string nombres = nombre.Text;
                string apellidos = apellido.Text;
                string correo = correos.Text;
                string contraseña = contraseñas.Text;


                WSClient client = new WSClient();

                var result = await client.Get<Boolean>("https://192.168.52.246/" +
                    "api/Registro?usuario=" + correo + "&contraseña=" + contraseña + "&nombre=" + nombres + "&apellido=" + apellidos);


                if (result)
                {
                    await DisplayAlert("Datos Guardados", "Registro Exitoso", "ok");


                    //await Navigation.PushAsync(new login());
                    App.Current.MainPage = new login();
                    Console.WriteLine("MainPage");

                }

            }
        }
    }
}