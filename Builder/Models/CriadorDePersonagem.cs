using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public abstract class CriadorDePersonagem
    {
        protected Personagem personagem;
        public Personagem ObterPersonagem()
        {
            return personagem;
        }

        public abstract void Cabeça();
        public abstract void Torso();
        public abstract void Perna();
    }
}