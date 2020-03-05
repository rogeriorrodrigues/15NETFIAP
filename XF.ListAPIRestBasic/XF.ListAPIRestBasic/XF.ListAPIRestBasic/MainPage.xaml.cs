using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ListAPIRestBasic
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private List<Contatinho> contatinhos;

        private void searchestados_TextChanged(object sender, TextChangedEventArgs e)
        {

            var texto = searchestados.Text;

            lstEstados.ItemsSource = contatinhos.Where(x => x.Bairro.ToLower().Contains(texto.ToLower()));

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            string url = "https://demo0772753.mockable.io/";

            var response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                contatinhos = JsonConvert.DeserializeObject<List<Contatinho>>(content);

                lstEstados.ItemsSource = contatinhos;


            }
        }
    }
}
