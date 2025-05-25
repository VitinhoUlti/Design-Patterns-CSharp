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
    }
}