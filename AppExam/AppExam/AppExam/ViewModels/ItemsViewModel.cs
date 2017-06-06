using AppExam.Models;
using AppExam.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AppExam.ViewModels
{
    public class ItemsViewModel :  BaseViewModel
    {
        public ObservableCollection<Coupon> UserCoupons { get; }

        public ItemsViewModel()
        {
            UserCoupons = new ObservableCollection<Coupon>();

            Title = "Meus Cupons";
        }

        public override async Task LoadAsync()
        {
            try
            {
                UserCoupons.Clear();
                var repo = new Repository();
                var coupons = await repo.GetCoupons();

                foreach (var item in coupons)
                {
                    UserCoupons.Add(item);
                }
            }
            catch(Exception e)
            {
                await DisplayAlert("Erro!", $"Erro ao recuperar dados dos cupons. Detalhes do erro: {e.Message}", "Fechar");                
            }
        }
    }
}
