using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class VitorConcreto : VitorModelo
    {
        private string Corpo;
        private string Mente;

        public VitorConcreto(string corpo, string mente)
        {
            Corpo = corpo;
            Mente = mente;
        }

        public override VitorModelo clone()
        {
            Console.WriteLine("O clone foi criado, ele está ativo agora");
            return this.MemberwiseClone() as VitorModelo;
        }
    }
}