using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microcharts.Forms;
using SkiaSharp.Views;
using SkiaSharp;
using Entry = Microcharts.Entry;
using Microcharts;

namespace cacke
{
    public partial class MainPage : ContentPage
    {

        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color=SKColor.Parse("#FBDB00"),
                Label ="Offen",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#FB0009"),
                Label = "Storneit Monteur",
                ValueLabel = "400"
            },
            new Entry(-100)
            {
                Color =  SKColor.Parse("#FB0009"),
                Label = "Storniet Call center",
                ValueLabel = "-100"
            },
            new Entry(100)
            {
                Color = SKColor.Parse("#00FB6A"),
                Label = "Abgeshlosen",
                ValueLabel = "222"
            }
        };

        public MainPage()
        {
            InitializeComponent();

            chart1.Chart = new RadialGaugeChart() { Entries = entries};
            chart2.Chart = new LineChart() { Entries = entries };

            txtname.Text = List_Users.users_main.firstname;

            TapGestureRecognizer bn = new TapGestureRecognizer();
            bn.Tapped += (s, e) =>
            {
                Navigation.PopModalAsync();
            };

            lblback_listuser.GestureRecognizers.Add(bn);
        }
    }
}
