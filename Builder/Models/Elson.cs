using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class Elson : Personagem
    {
        public override void EscolherCabeça(string cabeça)
        {
            Cabeça = cabeça;
        }
        public override void EscolherTorso(string torso)
        {
            Torso = torso;
        }
        public override void EscolherPerna(string perna)
        {
            Perna = perna;
        }
    }
}