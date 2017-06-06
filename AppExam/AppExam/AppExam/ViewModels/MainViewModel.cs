using AppExam.Services;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace AppExam.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private AzureService azureService = new AzureService();
        private MobileServiceUser user;

        private string _logonInfo = "";

        public Command AboutCommand { get; }
        public Command FacebookLogonCommand { get; }

        public string TextWelcome { get { return "Olá, bem vindo! Efetue logon abaixo para entrar."; }  }

        public string FacebookButtonText
        {
            get { return "Logar com Facebook"; }
        }

        public string LogonInfo
        {
            get { return _logonInfo; }
            set
            {
                _logonInfo = value;
                OnPropertyChanged();
                FacebookLogonCommand.ChangeCanExecute();
            }
        }

        public MainViewModel()
        {
            AboutCommand = new Command(ExecuteAboutCommand);
            FacebookLogonCommand = new Command(ExecuteFacebookLogonCommand);

            Title = "Fidelidade Doceria";
        }

        public async void ExecuteFacebookLogonCommand()
        {
            user = await azureService.LoginAsync();

            if (user != null)
            {
                await PushAsync<ItemsViewModel>();
                LogonInfo = "Bem vindo. Clique no botão abaixo para entrar.";
            }
            else
                LogonInfo = "Falha no login, tente novamente!";
        }

        public async void ExecuteAboutCommand()
        {
            await PushAsync<AboutViewModel>();  
        }
    }
}
