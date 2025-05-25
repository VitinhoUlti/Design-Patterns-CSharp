using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class Criador
    {
        public void ConstruirPersonagem(CriadorDePersonagem criadorDePersonagem)
        {
            criadorDePersonagem.Cabeça();
            criadorDePersonagem.Torso();
            criadorDePersonagem.Perna();
        }
    }
}