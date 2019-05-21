using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Model
{
    class MeuModel : INotifyPropertyChanged
    {
        private string _nome;
        private bool _isRobo;
        private DateTime _data;

        public MeuModel()
        {
            Data = DateTime.Today;
        }

        public string Nome { get => _nome; set { _nome = value; OnPropertyChanged(nameof(Nome)); } }
        public bool IsRobo { get => _isRobo; set { _isRobo = value; OnPropertyChanged(nameof(IsRobo)); }  }
        public DateTime Data { get => _data; set { _data = value; OnPropertyChanged(nameof(Data)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string nome)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
        }
    }
}
