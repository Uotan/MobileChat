using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileChat.Classes;
using MobileChat.Modules;

namespace MobileChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {

        List<string> nickN = new List<string>();


        public ChatPage()
        {
            InitializeComponent();
        }


        private void LightTheme_Clicked(object sender, EventArgs e)
        {
            ThemeClass.SetLight();
        }

        private void DarkTheme_Clicked(object sender, EventArgs e)
        {
            ThemeClass.SetDark();
        }

        private async void findUser_Clicked(object sender, EventArgs e)
        {
            string nickSearch = await DisplayPromptAsync("Введите ник", "Поиск");
            if (nickSearch!=ClassStatus.nick)
            {
                try
                {
                    string[] subs = WebClientModules.SearchUserMethod(nickSearch);
                    if (subs[0] == "ok")
                    {
                        nickN.Add(subs[1] + "-" + nickSearch);

                        usersList.ItemsSource=null;
                        usersList.ItemsSource = nickN;

                    }
                    else
                    {
                        await DisplayAlert("Error", "Пользователь не найден...", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "Ok");
                }
            }
            else
            {
                await DisplayAlert("Error", "Нельзя добавить самого себя", "Ok");
            }
            
        }

        private async void changeUserInfo_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangeInfo());
        }

        private async void usersList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //string[] subs = usersList.SelectedItem.ToString().Split('-');
            string[] subs = e.Item.ToString().Split('-');
            await Navigation.PushAsync(new MessagePage(subs[0]));
        }

        private async void exitBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}