using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Typo_EoulrimL.ttf", Alias = "RegularFont")]
[assembly: ExportFont("Typo_EoulrimM.ttf", Alias = "MediumFont")]
[assembly: ExportFont("Typo_EoulrimB.ttf", Alias = "BoldFont")]

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FontXam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
