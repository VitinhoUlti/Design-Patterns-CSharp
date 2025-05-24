using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class FabricaBasesMiguel : IFabricaBases
    {
        public FabricaBasesMiguel()
        {
            CriarBases();
        }

        public void CriarBases()
        {
            Console.WriteLine("Base do Miguel pronta");

            RevestimentoBaseMiguel revestimento = new RevestimentoBaseMiguel();
            revestimento.Composicao();

            EnergiaBaseMiguel energia = new EnergiaBaseMiguel();
            energia.Composicao();
        }
    }
}