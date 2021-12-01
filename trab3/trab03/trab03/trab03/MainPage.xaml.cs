using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace trab03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Res_Clicked(object sender, EventArgs e)
        {


            

            try
            {
                var mainpage = new MainPage();
                var httpClient = new HttpClient();
                var reponse = await httpClient.GetStringAsync("https://viacep.com.br/ws/01001000/json/");
                var login = JsonConvert.DeserializeObject<Login>(reponse);
                mainpage.BindingContext = login;
                cep.Text = login.cep;
                logradouro.Text = login.logradouro;
                complemento.Text = login.complemento;
                bairro.Text = login.bairro;
                localidade.Text = login.localidade;
                uf.Text = login.uf;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
    }
}
