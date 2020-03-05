using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ListAPIRestBasic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCEP : ContentPage
    {
        public BuscaCEP()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            string url = "https://viacep.com.br/ws/"+ txtCep.Text + "/json/";

            var response = await client.GetAsync(url);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var cep = JsonConvert.DeserializeObject<RetornoCep>(content);

                lblloc.Text = cep.Localidade;
                lbllog.Text = cep.Logradouro;
                lbluf.Text = cep.Uf;
                lblunidade.Text = cep.Unidade;
            
            }
            

        }
    }
}