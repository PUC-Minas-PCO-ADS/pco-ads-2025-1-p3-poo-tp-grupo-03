using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    public class PessoaJuridica : Consumidor
    {
        public string CNPJ { get; set; }
    }
}
