using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileChat.Classes;
using MobileChat.Modules;



namespace MobileChat
{
    public partial class MainPage : ContentPage
    {

        string serveradress1 = ServerAddress.srvrAddress;
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnLog_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] _result = WebClientModules.LoginMethod(tbLogin.Text, tbPassword.Text);
                if (_result[0] == "ok")
                {
                    ClassStatus.autorezult = _result[0];
                    ClassStatus.user_id = _result[1];
                    ClassStatus.nick = tbLogin.Text;
                    tbLogin.Text = null;
                    tbPassword.Text = null;
                    await Navigation.PushAsync(new ChatPage());
                }
                else
                {
                    await DisplayAlert("Error", "Неверный логин или пароль", "Ok");
                }
                
            }
            catch (Exception a)
            {

                await DisplayAlert("Error", a.Message , "Ok");
            }
            
        }
        private async void btnReg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrPage());
        }

        private void DarkTheme_Clicked(object sender, EventArgs e)
        {
            ThemeClass.SetDark();
        }

        private void LightTheme_Clicked(object sender, EventArgs e)
        {
            ThemeClass.SetLight();
        }
    }
}
