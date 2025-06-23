using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ControleDeEnergia.Models
{

    //adicionado pois o consumidorfactory nao conseguia difenrenciar os tipos de consumidor para serializar
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(PessoaFisica), "PessoaFisica")]
    [JsonDerivedType(typeof(PessoaJuridica), "PessoaJuridica")]
    public abstract class Consumidor
    {
        public string Nome { get; set; }
        public List<ContaDeEnergia> Contas = new();

        public void AdicionarConta(ContaDeEnergia conta)
        {
            Contas.Add(conta);
        }

        public List<ContaDeEnergia> ListarContas() => new List<ContaDeEnergia>(Contas);
    }
}
