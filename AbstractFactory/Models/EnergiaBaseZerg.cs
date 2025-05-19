using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao(){
            Console.WriteLine("Energia pela terra");
        }
    }
}