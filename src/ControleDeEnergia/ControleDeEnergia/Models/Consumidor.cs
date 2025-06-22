using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    public abstract class Consumidor
    {
        public string Nome { get; set; }
        protected List<ContaDeEnergia> Contas = new();

        public void AdicionarConta(ContaDeEnergia conta)
        {
            Contas.Add(conta);
        }
        public List<ContaDeEnergia> ListarContas()
        {
            return Contas;
        }
    }
}
