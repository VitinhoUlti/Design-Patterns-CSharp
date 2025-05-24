using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class FabricaBasesVitor : IFabricaBases
    {
        public FabricaBasesVitor()
        {
            CriarBases();
        }

        public void CriarBases()
        {
            Console.WriteLine("Base do vitor pronta");

            RevestimentoBaseVitor revestimento = new RevestimentoBaseVitor();
            revestimento.Composicao();

            EnergiaBaseVitor energia = new EnergiaBaseVitor();
            energia.Composicao();
        }
    }
}