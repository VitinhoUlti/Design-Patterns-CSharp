namespace FactoryMethod.Entidades
{
    public class FactoryMethodClass
    {
        public IPersonagem EscolherPersonagem(string personagem) {
            switch (personagem) {
                case "elson": return new Elson();
                case "vitor": return new Vitor();
                case "miguel": return new Miguel();
                default: return null;
            }
        }
    }
}