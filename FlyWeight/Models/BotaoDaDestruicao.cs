using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeight.Models
{
    public class BotaoDaDestruicao : Botao
    {
        public BotaoDaDestruicao(string cor)
        {
            Cor = cor;
        }
        public override void AcaoDoBotao()
        {
            Console.WriteLine("Explosãooooo");
        }
    }
}