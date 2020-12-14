using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using cacke.Models;
using SkiaSharp;
using System.Linq;
using Microcharts.Forms;


namespace cacke
{
    public partial class List_Users : ContentPage
    {
        public List_Users()
        {
            InitializeComponent();



            var httpClient = new HttpClient();
            var response = httpClient.GetStringAsync("http://api1337.1337center.de/api/users").Result;



            var f = JsonConvert.DeserializeObject<List<user>>(response);


            int p = f.Count;

            ls.ItemsSource = f.ToList<user>();


            ls.ItemSelected += list_Selected;
            // var employee = JsonConvert.DeserializeObject<List<employee>>(response);
        }


        public static user users_main;

        private  async void list_Selected(object sender,SelectedItemChangedEventArgs e)
        {
            users_main = (user) e.SelectedItem;

            await Navigation.PushModalAsync(new MainPage());
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();

         
            //name1.Text = f[0].firstname;

          //  ls.ItemsSource = f.ToList();
//            oncl(fr1, btn_click);



        }



        public TapGestureRecognizer  oncl(Frame sender,EventHandler e)
        {
            TapGestureRecognizer ef = new TapGestureRecognizer();
            ef.Tapped += e;
            sender.GestureRecognizers.Add(ef);
            return ef;
        }


        public  async void btn_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
