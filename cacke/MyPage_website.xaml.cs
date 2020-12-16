using System;
using System.Collections.Generic;
using cacke.helprs;
using cacke.Models;
using Xamarin.Forms;
using System.Linq;

namespace cacke
{
    public partial class MyPage_website : ContentPage
    {
        public MyPage_website()
        {
            InitializeComponent();



            var ls = Helpers_api.get_allwebsite();

            lis.ItemsSource = ls.ToList();

        }

    }
}
