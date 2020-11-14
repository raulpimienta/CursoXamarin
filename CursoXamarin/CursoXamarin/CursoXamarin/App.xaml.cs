using CursoXamarin.PageModels;
using FreshMvvm;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CultureInfo cultureInfo = new CultureInfo("es-MX");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU1NDQyQDMxMzgyZTMxMmUzMENsR3ZESHA5d2NlZ0FiaThsK25iV2c1b3BJc3BQWm01RTB2SWhHajkwbFk9");


            var login = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            var basicContainer = new FreshNavigationContainer(login);

            MainPage = basicContainer;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
