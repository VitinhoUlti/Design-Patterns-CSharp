using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao(){
            Console.WriteLine("Energia de cristais");
        }
    }
}