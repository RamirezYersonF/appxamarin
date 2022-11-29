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
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void registro_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new registro();
            Console.WriteLine("Registro");
        }

        private void iniciarsesion_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new login();
            Console.WriteLine("Registro");
        }
    }
}