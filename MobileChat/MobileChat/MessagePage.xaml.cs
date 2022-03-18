﻿using System;
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

namespace MobileChat
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessagePage : ContentPage
    {
        string idMes;
        string countOfMessages;
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
                    messagesList.Clear();
                    var _searchAnswer = WebClientModules.ShowMessageMethod(idMes);

                    if (_searchAnswer!=null)
                    {
                        collectionView.ItemsSource = _searchAnswer;
                    }
                    countOfMessages = _searchAnswer.Count.ToString();
                    collectionView.ScrollTo(_searchAnswer.Count - 1);


                }
                else
                {
                    var countRequest = WebClientModules.getCountOfMessages(idMes);
                    if (countOfMessages!=countRequest)
                    {
                        messagesList.Clear();
                        var _searchAnswer = WebClientModules.ShowMessageMethod(idMes);
                        collectionView.ItemsSource = _searchAnswer;
                        countOfMessages = _searchAnswer.Count.ToString();
                        collectionView.ScrollTo(_searchAnswer.Count-1);
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
    }
}