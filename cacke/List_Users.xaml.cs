﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using cacke.Models;


namespace cacke
{
    public partial class List_Users : ContentPage
    {
        public List_Users()
        {
            InitializeComponent();



           // var employee = JsonConvert.DeserializeObject<List<employee>>(response);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://api1337.1337center.de/api/users").Result;

        

            var f = JsonConvert.DeserializeObject<List<user>>(response);


            int p = f.Count;
            name1.Text = f[0].firstname;


        }
    }
}
