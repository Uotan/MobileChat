using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileChat.Modules;

namespace MobileChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeInfo : ContentPage
    {
        public ChangeInfo()
        {
            InitializeComponent();
        }
        
        private async void btChangePassw_Clicked(object sender, EventArgs e)
        {
            if (entrNewPass1.Text==entrNewPass2.Text)
            {
                string answer = WebClientModules.changePassword(ClassStatus.user_id, entrActPass.Text, entrNewPass1.Text);
                if (answer.Contains("Updated"))
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "ошибка смены пароля", "ок");
                }
                
            }
            else
            {
                await DisplayAlert("Error","пароли не совпадают","ок");
            }
        }
    }
}