
using AppExam.Services;
using System;
using Xamarin.Forms;

namespace AppExam.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private AzureService azureService = new AzureService();

        private string _logonInfo = "";

        public Command AboutCommand { get; }
        public Command FacebookLogonCommand { get; }

        

        public string TextWelcome { get { return "Olá, bem vindo! Efetue logon abaixo para entrar."; }  }

        public string LogonInfo
        {
            get { return _logonInfo; }
            set
            {
                _logonInfo = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AboutCommand = new Command(ExecuteAboutCommand);
            FacebookLogonCommand = new Command(ExecuteFacebookLogonCommand);

            Title = "Fidelidade Brigaderia";
        }

        public async void ExecuteFacebookLogonCommand()
        {
            var user = await azureService.LoginAsync();

            LogonInfo = (user != null) ? $"Bem vindo: {user.UserId}" : "Falha no login, tente novamente!";
        }

        public async void ExecuteAboutCommand()
        {
            await PushAsync<AboutViewModel>();  
        }
    }
}
