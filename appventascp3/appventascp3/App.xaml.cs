using appventascp3.Services;
using appventascp3.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appventascp3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new inicio();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
