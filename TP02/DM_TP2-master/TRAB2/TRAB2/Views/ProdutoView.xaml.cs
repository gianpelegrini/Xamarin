using System;
using TRAB2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRAB2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoView : ContentPage
    {
        public ProdutoView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Id = int.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                Categoria = txtCategoria.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = double.Parse(txtPreco.Text),
            };

            var produtoPage = new ProdutoDetalhe();
            produtoPage.BindingContext = produto;
            await Navigation.PushAsync(produtoPage);
        }
    }
}