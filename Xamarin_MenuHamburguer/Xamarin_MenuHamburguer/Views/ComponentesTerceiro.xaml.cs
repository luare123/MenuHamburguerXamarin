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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }
        private async void net_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Internet e Protocolos",

                    AtribuicoesResponsabilidades = "Utilizar protocolos de redes e internet para comunicação de dados",

                    ValoresAtitudes = "~ Incentivar comportamentos éticos\n ~ Promover ações que considerem o respeito às normas estabelecidas\n" +
                    "~ Fortalecer a persistência e o interesse na resolução de situações-problema"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void banco_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Banco de Dados III",

                    AtribuicoesResponsabilidades = "Realizar gestão de bancos de dados",

                    ValoresAtitudes = "~ Incentivar a criatividade\n ~ Desenvolver a criticidade\n ~ Fortalecer a persistência e o interesse" +
                    "na resolução de situações-problema"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void mobile_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Programação de Aplicativos Mobile II",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis",

                    ValoresAtitudes = "~ Responsabilizar-se pela produção, utilização e divulgação de informações\n ~ Incentivar a criatividade\n" +
                    "~ Estimular a organização"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void web_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Programação Web III",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web",

                    ValoresAtitudes = "~ Responsabilizar-se pela produção, utilização e divulgação de informações\n ~ Incentivar a criatividade\n" +
                    "~ Estimular a organização"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void testesoft_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas",

                    ValoresAtitudes = "~ Responsabilizar-se pela produção, utilização e divulgação de informações\n ~ Estimular a proatividade\n" +
                    "~ Desenvolver criticidade"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void tcc_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais",

                    ValoresAtitudes = "~ Planejar ações mais eficazes no desenvolvimento de sistemas\n ~ Demonstra comprometimento com equipe e o trabalho"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Port_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Língua Portuguesa, Literatura e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando a terminologia técnico-científica da área com" +
                    "autonomia, clareza e precisão.",

                    ValoresAtitudes = "~ Incentivar o diálogo e a interlocução \n" +
                    "~ Estimular o interesse na resolução de situações-problema \n" +
                    "~ Responsabilizar-se pela produção, realização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void ingles_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Língua Estrangeira Moderna - Inglês e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira utilizando o vocabulário e a terminologia" +
                    "técnico-cientifica da área",

                    ValoresAtitudes = "~ Incentivar ações que promovam a cooperação\n" +
                    "~ Respeitar as manifestações culturais de outros povos\n" +
                    "~ Estimular o interesse na resolução de situações-problema\n"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void geo_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Geografia",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void mat_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Matemática",

                    AtribuicoesResponsabilidades = "Implementar algoritmos em linguagem de programação" +
                    ", utlizando ambientes de desenvolvimento de acordo com as necessidades",

                    ValoresAtitudes = "~ Socializar os saberes \n ~ Estimular o interesse na resolução" +
                    "de situações-problema\n ~ Responsabilizar-se pela produção, utilização e " +
                    "divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void bio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Biologia",

                    AtribuicoesResponsabilidades = "Desenvolver o conhecimento cíentifico, ou seja, a capacidade de compreender " +
                    "e interpretar o mundo, mas também de transformá-lo",

                    ValoresAtitudes = "~ Estimular o interesse pela realidade que nos cerca\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void quimica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Química",

                    AtribuicoesResponsabilidades = "Pesquisar as interações e transformações químicas na natureza dos processos" +
                    "de produção e nas tecnologias",

                    ValoresAtitudes = "~ Estimular o interesse pela realidade que nos cerca\n" +
                    "~ Estimular o interesse na resolução de situações-problema\n" +
                    "~ Promover ações que considerem o respeito às normas estabelecidas"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void hist_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "História",

                    AtribuicoesResponsabilidades = "Pesquisar sobre a influência das tecnologias nos" +
                    "processos sociais e de produção",

                    ValoresAtitudes = "~ Incentivar comportamentos éticos\n" +
                    "~ Respeitar as manifestações culturais de outros povos\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void fisica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Física",

                    AtribuicoesResponsabilidades = "Pesquisar as interações e transformações físicas" +
                    "na natureza dos processos de produção e nas tecnologias",

                    ValoresAtitudes = "~ Estimular o interesse na resolução de situações-problema\n" +
                    "~ Promover ações que considerem o respeito às normas estabelecidas\n" +
                    "~ Responsabilizar-se pela produção, utilização e divulgação de informações"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void filoso_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Filosofia",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void socio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Sociologia",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void educacao_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Educação Física",

                    AtribuicoesResponsabilidades = "Utilizar técnicas e práticas de atividade física" +
                    "nos contextos de trabalho",

                    ValoresAtitudes = "~ Incentivar atitudes de autonomia\n" +
                    "~ Incentivar ações que promovam a cooperação"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
    }
}