using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF.ListAPIRestBasic
{
    public class Contatinho
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("origem")]
        public string Origem { get; set; }
    }
}
