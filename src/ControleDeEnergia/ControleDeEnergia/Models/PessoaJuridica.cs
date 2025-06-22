using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    internal class PessoaJuridica : Consumidor
    {
        public string cnpj { get; set; }
    }
}
