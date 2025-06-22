using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    public abstract class ContaDeEnergia
    {
        public int Id { get; set; }
        public double LeituraAtual { get; set; }
        public double LeituraAnterior { get; set; }
        public DateTime DataConta { get; set; }
        public string Instalacao { get; set; }


        /*O consumo é dado pela diferença
        entre as duas leituras */
        public double CalcularConsumo()
        {
            return LeituraAtual - LeituraAnterior;
        }


        /* Métodos abstratos para serem implementados nas classes derivadas,
        pois cada tipo de conta pode ter uma lógica diferente para calcular o
        valor total e o valor sem impostos.
        */
        public abstract double CalcularValorTotal();
        public abstract double CalcularValorSemImpostos();


    }
}
