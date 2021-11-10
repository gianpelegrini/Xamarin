using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRAB2.Models;
using TRAB2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRAB2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Idade = int.Parse(txtIdade.Text),
                Profissao = txtProfissao.Text,
                Pais = txtPais.Text,
            };

            var detalhePage = new DetalheView();
            detalhePage.BindingContext = contato;
           await Navigation.PushAsync(detalhePage);
        }
    }
}