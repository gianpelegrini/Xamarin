using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TRAB2.ViewModel
{
    class DetalheViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int idade;
        string profissao, nome,pais;

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }
        public int Idade
        {
            get => idade;
            set
            {
                idade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Idade"));
            }
        }
        public string Profissao
        {
            get => profissao;
            set
            {
                profissao = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Profissao"));
            }
        }
        public string Pais
        {
            get => pais;
            set
            {
                pais = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Pais"));
            }
        }
    }
}
