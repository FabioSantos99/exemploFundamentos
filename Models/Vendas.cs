using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public int Id { get; set;}
        [JsonProperty("Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

    }
}