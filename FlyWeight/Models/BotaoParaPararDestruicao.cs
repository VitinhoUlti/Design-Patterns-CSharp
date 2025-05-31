using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeight.Models
{
    public class BotaoParaPararDestruicao : Botao
    {
        public BotaoParaPararDestruicao(string cor)
        {
            Cor = cor;
        }
        public override void AcaoDoBotao()
        {
            Console.WriteLine("Você parou a explosão parabéns!");
        }
    }
}