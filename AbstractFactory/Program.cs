using AbstractFactory.Models;

IFabricaBases fabrica;
Console.WriteLine("Escolha sua base para a luta: vitor, elson, miguel");

switch (Console.ReadLine())
{
    case "vitor":
        fabrica = new FabricaBasesVitor();
        break;
    case "elson":
        fabrica = new FabricaBasesElson();
        break;
    case "miguel":
        fabrica = new FabricaBasesMiguel();
        break;
    default:
        Console.WriteLine("esse personagem não esta disponivel");
        break;
}
