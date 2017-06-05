using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExam.ViewModels
{
    public class ItemsViewModel :  BaseViewModel
    {
        private int _quantidade = 10;
        public string QuantidadeItens { get { return $"Você possui {_quantidade} cupons"; } }

        public ItemsViewModel()
        {
            Title = "Meus Cupons";
        }
    }
}
