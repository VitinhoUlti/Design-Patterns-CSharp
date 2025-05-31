using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeight.Models
{
    public abstract class Botao
    {
        protected bool Apertado = false;

        public abstract void AcaoDoBotao();
    }
}