using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_MenuHamburguer.Views;
using Xamarin_MenuHamburguer.Models;

namespace Xamarin_MenuHamburguer
{
    public partial class MainPage : MasterDetailPage
    {
        App PropriedadesApp;
        public MainPage()
        {
            InitializeComponent();
            PropriedadesApp = (App)Application.Current;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
            lbl_boasvindas.Text = string.Format(
                "Bem-vindo (a) {0} ",
                App.Current.Properties["usuario_logado"].ToString()
            );
        }       

        private async void open_inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void open_primeiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesPrimeiro)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void open_segundo(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesSegundo)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void open_terceiro(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesTerceiro)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void open_vestibulinho(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void open_contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void sair_clicked(object sender, EventArgs e)
        {
            try
            {
                bool confirmacao = await DisplayAlert("Tem certeza?", "Sair do App?", "Sim", "Não");
                if (confirmacao)
                {
                    App.Current.Properties.Remove("usuario_logado");
                    App.Current.MainPage = new login();
                }
            }
            catch
            {

            }
        }
    }
}
