using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SkiaSharp;
using Entry = Microcharts.Entry;
using Microcharts;

namespace cacke
{
    public partial class page_Home : ContentPage
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

        public page_Home()
        {
            InitializeComponent();

            chart1.Chart = new RadialGaugeChart() { Entries = entries };
            chart2.Chart = new LineChart() { Entries = entries };

        }
    }
}
