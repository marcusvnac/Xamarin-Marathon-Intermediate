using Lab04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab04
{
    public partial class MainPage : ContentPage
    {
        readonly AzureService azureService = new AzureService();

        public MainPage()
        {
            InitializeComponent();

            LoginButton.Clicked += async (sender, e) =>
            {
                var user = await azureService.LoginAsync();

                InfoLabel.Text = (user != null) ? $"Bem vindo: {user.UserId}" : "Falha no login, tente novamente!";
            };
        }
    }
}
