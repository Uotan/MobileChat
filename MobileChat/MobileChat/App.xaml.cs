using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileChat.Classes;

namespace MobileChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();



            NavigationPage mainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#0E547C"),
                BarTextColor = Color.White
            };
            Application.Current.RequestedThemeChanged += (object sender, AppThemeChangedEventArgs e) =>
            {
                if (e.RequestedTheme == OSAppTheme.Dark)
                    ThemeClass.SetDark();
                else
                    ThemeClass.SetLight();
            };

            MainPage = mainPage;
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
