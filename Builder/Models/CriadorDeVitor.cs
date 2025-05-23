using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class CriadorDeVitor : CriadorDePersonagem
    {
        public CriadorDeVitor()
        {
            personagem = new Vitor();
        }

        public override void Cabeça()
        {
            personagem.EscolherCabeça("Cabeça do Vitor");
        }
        public override void Torso()
        {
            personagem.EscolherTorso("Torso do Vitor");
        }
        public override void Perna()
        {
            personagem.EscolherPerna("Perna do Vitor");
        }
    }
}