using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeight.Models
{
    public abstract class Botao
    {
        protected bool Apertado = false;
        public string Cor { get; set; }

        public abstract void Mostar(string cor);
        public abstract void AcaoDoBotao();
    }
}