namespace Inclass8Activity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsHomepage());
        }
    }
}
