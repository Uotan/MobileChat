using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
