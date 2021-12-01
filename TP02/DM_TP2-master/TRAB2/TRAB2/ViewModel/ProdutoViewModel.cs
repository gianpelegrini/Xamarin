using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TRAB2.ViewModel
{
    class ProdutoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int id, quantidade;
        double preco;
        string categoria, descricao;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        public int Quantidade
        {
            get => quantidade;
            set
            {
                quantidade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Quantidade"));
            }
        }
        public string Descricao
        {
            get => descricao;
            set
            {
                descricao = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Descricao"));
            }
        }
        public string Categoria
        {
            get => categoria;
            set
            {
                categoria = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Categoria"));
            }
        }
        public double Preco
        {
            get => preco;
            set
            {
                preco = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Preco"));
            }
        }
    }
}
