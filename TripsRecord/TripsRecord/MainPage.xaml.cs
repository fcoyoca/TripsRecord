﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripsRecord.Model;
using Xamarin.Forms;

namespace TripsRecord
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var assembly = typeof(MainPage);


            iconImage.Source = ImageSource.FromResource("TripsRecord.Assets.Images.manphone.png", assembly);
		}

        private async void loginButton_Clicked(object sender, EventArgs e)
        {

            //bool isEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            //bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            //if (isEmailEmpty || isPasswordEmpty)
            //{
            //}
            //else
            //{
            //    var user = (await App.MobileService.GetTable<User>().Where(u => u.Email == emailEntry.Text).ToListAsync()).FirstOrDefault();

            //    if (user != null)
            //    {
            //        App.user = user;
            //        if (user.Password == passwordEntry.Text)
            //        {
            //            await Navigation.PushAsync(new HomePage());
            //        }
            //        else
            //        {
            //            await DisplayAlert("Error", "Email or password are incorrect", "Ok");
            //        }

            //    }
            //    else
            //    {
            //        await DisplayAlert("Error", "Email or password are incorrect", "Ok");
            //    }

            //}

            bool canLogin = await User.Login(emailEntry.Text, passwordEntry.Text);
            if (canLogin)
                await Navigation.PushAsync(new HomePage());
            else
                await DisplayAlert("Error", "Email or password are incorrect", "Ok");

        }

        private void registerUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

    }
}
