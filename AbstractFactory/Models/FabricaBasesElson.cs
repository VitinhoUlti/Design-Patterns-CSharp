using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class FabricaBasesElson : IFabricaBases
    {
        public FabricaBasesElson()
        {
            CriarBases();
        }

        public void CriarBases()
        {
            Console.WriteLine("Base do Elson pronta");

            RevestimentoBaseElson revestimento = new RevestimentoBaseElson();
            revestimento.Composicao();

            EnergiaBaseElson energia = new EnergiaBaseElson();
            energia.Composicao();
        }
    }
}