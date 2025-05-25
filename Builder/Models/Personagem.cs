using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public abstract class Personagem
    {
        public string Cabeça { get; protected set; }
        public string Torso { get; protected set; }
        public string Perna { get; protected set; }
        
        public abstract void EscolherCabeça(string cabeça);
        public abstract void EscolherTorso(string torso);
        public abstract void EscolherPerna(string perna);
    }
}