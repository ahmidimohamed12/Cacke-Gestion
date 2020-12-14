using System;
using System.Collections.Generic;
using cacke.helprs;
using cacke.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;

namespace cacke
{
    public partial class Logins : ContentPage
    {
        private object httpClient;

        public Logins()
        {
            InitializeComponent();
            btn_login.Clicked += btn_click;
        }



        private async void btn_click(object sender,EventArgs e)
        {
            var users = Helpers_api.loggin_test(txtusername.Text, txtpassword.Text);

            

            await Navigation.PushModalAsync(new MyMasterDetailPage());

        }
    }
}
