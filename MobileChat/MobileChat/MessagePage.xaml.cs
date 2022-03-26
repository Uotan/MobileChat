using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileChat.Classes;
using MobileChat.Modules;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using static MobileChat.Modules.WebClientModules;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit.Extensions;

namespace MobileChat
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagePage : ContentPage
    {
        string idMes;
        int countOfMessages;
        bool firstTime = true;
        ObservableCollection<Message> messagesList = new ObservableCollection<Message>();

        public MessagePage(string id)
        {
            InitializeComponent();
            idMes = id;
            MessageShow();
            Device.StartTimer(new TimeSpan(0, 0, 2), () =>
            {
                // do something every 60 seconds
                Device.BeginInvokeOnMainThread(() =>
                {
                    MessageShow();
                    //messgRefresh_Refreshing(null,null);
                });
                return true; // runs again, or false to stop
            });
        }
        private async void MessageShow()
        {
            try
            {
                if (firstTime)
                {
                    firstTime = false;
                    int countRequest = WebClientModules.getCountOfMessages(idMes);
                    var _searchAnswer = WebClientModules.ShowMessageMethod(idMes, countRequest);

                    if (_searchAnswer!=null)
                    {
                        foreach (var item in _searchAnswer)
                        {
                            messagesList.Add(item);
                        }
                    }
                    collectionView.ItemsSource = messagesList;
                    countOfMessages = messagesList.Count;
                    collectionView.ScrollTo(messagesList.Count - 1);


                }
                else
                {
                    int countRequest = WebClientModules.getCountOfMessages(idMes);
                    
                    if (countOfMessages!=countRequest)
                    {
                        int fetchCount = countRequest - countOfMessages;
                        

                        var _searchAnswer = WebClientModules.ShowMessageMethod(idMes, fetchCount);
                        foreach (var item in _searchAnswer)
                        {
                            messagesList.Add(item);
                        }
                        countOfMessages = messagesList.Count;
                        collectionView.ScrollTo(messagesList.Count - 1);
                    }
                }
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("error", ex.Message, "Ok");
            }
        }

        private async void back_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("ok", "back", "back");
            await Navigation.PushModalAsync(new ChatPage());
        }
        private async void change_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("ok", "change", "back");
            await Navigation.PushModalAsync(new ChangeInfo());
        }

        private void tbMess_Completed(object sender, EventArgs e)
        {
            if (tbMess.Text != null || tbMess.Text != "")
            {
                string answer = WebClientModules.SendMessageMethod(idMes, tbMess.Text);
                tbMess.Text = null;
            }
        }

        private async void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Message messageItem = (Message)e.CurrentSelection.FirstOrDefault();
            Debug.WriteLine(messageItem.content);
            await Clipboard.SetTextAsync(messageItem.content);
            await this.DisplayToastAsync("Text copied",2000);
        }
    }
}