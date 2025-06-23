using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEnergia.Models
{
    public class ContaComercial: ContaDeEnergia
    {
        /* De acordo com a regra de negócio dada no exercicio : 
        Para contas comerciais, a tarifa é R$ 0,35 por kW/h
        Ambos os tipos de conta pagam também um adicional de R$
        9,25 a título de “contribuição para iluminação pública”*/
        public override double CalcularValorSemImpostos()
        {
            return (CalcularConsumo() * 0.35) + 9.25;
        }

        /* O valor total da conta é dado la soma do valor do consumo com o valor 
        peda contribuição e, ainda, o imposto cobrado sobre esta soma. 
        Para consumidores comerciais, o imposto é de 18% (que sera 1.18 * o valor sem imposto) */

        public override double CalcularValorTotal()
        {
            return CalcularValorSemImpostos() * 1.18;
        }
    }
}
