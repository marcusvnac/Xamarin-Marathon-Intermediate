using Version.Plugin;

namespace AppExam.ViewModels
{
    public class AboutViewModel: BaseViewModel
    {
        public string Version { get { return CrossVersion.Current.Version; } }
    }
}
