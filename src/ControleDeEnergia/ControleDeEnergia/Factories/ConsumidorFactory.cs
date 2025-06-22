using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEnergia.Models;

namespace ControleDeEnergia.Factories
{
    public static class ConsumidorFactory
    {
        /* Cria um consumidor do tipo especificado.
        "PF" para Pessoa Fisica, "PJ" para Pessoa Juridica
        ele faz um switch e na escolha do tipo de pessoa ele ira instanciar o objeto
        da devida classe*/
        public static Consumidor CriarConsumidor(string tipo, string nome, string documento)
        {
            return tipo switch
            {
                "PF" => new PessoaFisica { Nome = nome, cpf = documento },
                "PJ" => new PessoaJuridica { Nome = nome, cnpj = documento }
            };
        }
    }
}
