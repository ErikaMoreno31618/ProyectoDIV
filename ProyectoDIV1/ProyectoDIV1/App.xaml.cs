using ProyectoDIV1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoDIV1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new inicioPortada();
            MainPage = new inicioDiseno();
            MainPage = new inicioInnovacion();
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
