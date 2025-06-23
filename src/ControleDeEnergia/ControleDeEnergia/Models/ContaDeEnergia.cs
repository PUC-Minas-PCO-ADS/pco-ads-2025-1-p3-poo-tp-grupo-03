using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(ContaResidencial), "ContaResidencial")]
    [JsonDerivedType(typeof(ContaComercial), "ContaComercial")]
    public abstract class ContaDeEnergia
    {
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
