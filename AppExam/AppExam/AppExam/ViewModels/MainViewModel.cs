using Xamarin.Forms;

namespace AppExam.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Command AboutCommand { get; }

        public MainViewModel()
        {
            AboutCommand = new Command(ExecuteAboutCommand);
        }

        public async void ExecuteAboutCommand()
        {
            await PushAsync<AboutViewModel>();  
        }
    }
}
