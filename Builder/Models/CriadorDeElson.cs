using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class CriadorDeElson : CriadorDePersonagem
    {
        public CriadorDeElson()
        {
            personagem = new Elson();
        }

        public override void Cabeça()
        {
            personagem.EscolherCabeça("Cabeça do Elson");
        }
        public override void Torso()
        {
            personagem.EscolherTorso("Torso do Elson");
        }
        public override void Perna()
        {
            personagem.EscolherPerna("Perna do Elson");
        }
    }
}