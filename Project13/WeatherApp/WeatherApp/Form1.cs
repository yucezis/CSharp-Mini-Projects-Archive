using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public async void HavaDurumunuGetir(string sehir)
        {
            string secsehir = sehir.ToLower();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"url/{secsehir}/EN"),
                Headers =
    {
        { "key", "" },
        { "key","" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);

                var fahrenheit = json["main"]["temp"].ToString();
                lblFah.Text = fahrenheit;

                var nem = json["main"]["humidity"].ToString();
                lblNem.Text = nem;

                var wind = json["wind"]["speed"].ToString();
                lblWind.Text = wind;

                var hissedilen = json["main"]["feels_like"].ToString();
                lblFeel.Text = hissedilen;

                double cel = (double.Parse(fahrenheit)-32)/1.8;
                lblCel.Text = cel.ToString();

                var hava = json["weather"]["main"].ToString();
                lblHava.Text = hava;


                lblCity.Text = sehir;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenSehir = comboBox1.SelectedItem.ToString();
            HavaDurumunuGetir(secilenSehir);
        }
    }
}
