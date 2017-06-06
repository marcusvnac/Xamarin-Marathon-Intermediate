using AppExam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppExam.ViewModels
{
    public class ItemsViewModel :  BaseViewModel
    {
        private List<UserCoupon> coupons;
        private int _quantidade = 10;
        public string QuantidadeItens { get { return $"Você possui {_quantidade} cupons"; } }

        public ItemsViewModel()
        {
            coupons = new List<UserCoupon>();

            Title = "Meus Cupons";
        }

        public override async Task LoadAsync()
        {
            // Mock
            coupons.Add(new UserCoupon("Brigadeiro", 10));
            coupons.Add(new UserCoupon("Cajuzinho", 5));
        }
    }
}
