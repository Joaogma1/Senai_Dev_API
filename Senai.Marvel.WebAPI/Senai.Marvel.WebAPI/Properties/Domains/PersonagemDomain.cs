using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Marvel.WebAPI.Properties.Domains
{
    public class PersonagemDomain
    {
        public int ID { get; set; }
        public string NomePersonagem { get; set; }
        public string Lancamento { get; set; }
        public string Descricao { get; set; }
    }
}
