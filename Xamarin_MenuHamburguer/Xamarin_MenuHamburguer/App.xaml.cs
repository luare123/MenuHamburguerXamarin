using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_MenuHamburguer.Models;
using Xamarin_MenuHamburguer.Views;

namespace Xamarin_MenuHamburguer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Properties.ContainsKey("usuario_logado"))
            {
                MainPage = new MainPage();
            }
            else
                MainPage = new login();
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
