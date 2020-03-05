using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ListView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();





            lstEstados.ItemsSource = listaContatinho;
        }

        public List<Contatinhos> listaContatinho = new List<Contatinhos> {
                new Contatinhos { Nome = "Juliana", Bairro = "Itaquera", Origem = "Happen" },
                new Contatinhos { Nome = "Mariana", Bairro = "Capão Redondo", Origem = "Tinder"},
                new Contatinhos { Nome = "Simone", Bairro = "Tatuape", Origem ="POF"},
                new Contatinhos { Nome = "Maria", Bairro = "Itaquera", Origem = "Happen" },
                new Contatinhos { Nome = "Carol", Bairro = "Capão Redondo", Origem = "Tinder"},
                new Contatinhos { Nome = "Patricia", Bairro = "Tatuape", Origem ="POF"},
                new Contatinhos { Nome = "Juliana M.", Bairro = "Itaquera", Origem = "Happen" },
                new Contatinhos { Nome = "Vivian", Bairro = "Capão Redondo", Origem = "Tinder"},
                new Contatinhos { Nome = "Roberta A", Bairro = "Itaquera", Origem = "Happen" },
                new Contatinhos { Nome = "Amanda", Bairro = "Capão Redondo", Origem = "Tinder"},
                new Contatinhos { Nome = "Cleonice", Bairro = "Tatuape", Origem ="POF"},
                new Contatinhos { Nome = "Jurema", Bairro = "Tatuape", Origem ="POF"},
                };

        public class Contatinhos
        {
            public string Nome { get; set; }
            public string Bairro { get; set; }
            public string Origem { get; set; }
        }

        List<String> estados = new List<String>
        {
            "Acre (AC)","Alagoas (AL)","Amapá (AP)","Amazonas (AM)","Bahia (BA)","Ceará (CE)","Distrito Federal (DF)","Espírito Santo (ES)",
            "Goiás (GO)","Maranhão (MA)","Mato Grosso (MT)","Mato Grosso do Sul(MS)","Minas Gerais(MG)","Pará(PA)","Paraíba(PB)",
            "Paraná(PR)","Pernambuco(PE)","Piauí(PI)","Rio de Janeiro(RJ)","Rio Grande do Norte(RN)","Rio Grande do Sul(RS)",
            "Rondônia(RO)","Roraima(RR)","Santa Catarina(SC)","São Paulo(SP)","Sergipe(SE)","Tocantins(TO)"
        };

        private void searchestados_TextChanged(object sender, TextChangedEventArgs e)
        {

            var texto = searchestados.Text;

            lstEstados.ItemsSource = listaContatinho.Where(x => x.Bairro.ToLower().Contains(texto.ToLower()));

        }
    }
}
