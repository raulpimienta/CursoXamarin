using CursoXamarin.PageModels;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var login = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            var basicContainer =new FreshNavigationContainer(login);

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
