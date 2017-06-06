//using Version.Plugin;

namespace AppExam.ViewModels
{
    public class AboutViewModel: BaseViewModel
    {
        public string Version { get { return "1.0a"; } } 

        public AboutViewModel()
        {
            Title = "Sobre";
        }
    }
}
