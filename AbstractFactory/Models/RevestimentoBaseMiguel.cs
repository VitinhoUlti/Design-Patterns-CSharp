using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class RevestimentoBaseMiguel : IRevestimento
    {
        public void Composicao(){
            Console.WriteLine("Base de rubis");
        }
    }
}