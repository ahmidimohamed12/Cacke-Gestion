﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cacke
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Logins();
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
