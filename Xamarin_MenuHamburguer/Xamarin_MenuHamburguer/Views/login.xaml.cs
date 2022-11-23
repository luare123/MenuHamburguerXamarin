using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_MenuHamburguer.Models;

namespace Xamarin_MenuHamburguer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();       
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                List<Usuarios> lista_usuarios = new List<Usuarios>
                {
                    new Usuarios()
                    {
                        Email = "usuario@gmail",
                        Nome = "Usuario padrão",
                        Senha = "123"
                    }
                };               

                Usuarios dados_digitados = new Usuarios()
                {
                    Email = txt_email.Text,
                    Senha = txt_senha.Text
                };
                if (lista_usuarios.Any(i => (i.Email == dados_digitados.Email && i.Senha == dados_digitados.Senha)))
                {                    
                    App.Current.Properties.Add("usuario_logado", txt_email.Text);
                    App.Current.MainPage = new MainPage();
                }
                else
                {                    
                    throw new Exception("Dados Incorretos, tente novamente.");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}