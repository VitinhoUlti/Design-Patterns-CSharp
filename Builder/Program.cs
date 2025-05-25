using Builder.Models;

Criador criador = new Criador();
CriadorDePersonagem criadorDePersonagem;
Personagem personagem;

criadorDePersonagem = new CriadorDeVitor();
criador.ConstruirPersonagem(criadorDePersonagem);
personagem = criadorDePersonagem.ObterPersonagem();
Console.WriteLine($"Vitor entra na siulação, ele tem {personagem.Cabeça}, {personagem.Torso} e {personagem.Perna}");

criadorDePersonagem = new CriadorDeElson();
criador.ConstruirPersonagem(criadorDePersonagem);
personagem = criadorDePersonagem.ObterPersonagem();
Console.WriteLine($"Elson entra na siulação, ele tem {personagem.Cabeça}, {personagem.Torso} e {personagem.Perna}");