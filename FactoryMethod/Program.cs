using FactoryMethod.Entidades;

FactoryMethodClass factoryMethod = new FactoryMethodClass();

Console.WriteLine("Escolha seu personagem: elson, vitor ou miguel");
string personagem = Console.ReadLine();

IPersonagem personagemEscolhido = factoryMethod.EscolherPersonagem(personagem);

Console.Write(personagem + ": ");
personagemEscolhido.Escolhido();