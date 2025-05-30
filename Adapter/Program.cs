using Adapter.Models;

Tomada2Pinos tomada2Pinos = new Tomada2Pinos();
Cabo3Pinos cabo3Pinos = new Cabo3Pinos();

Adaptador adaptador = new Adaptador(cabo3Pinos);

Console.WriteLine("Colocou o cabo na tomada de 2 pinos");
tomada2Pinos.ReceberEnergia();
tomada2Pinos.Energizar();

Console.WriteLine("Pegou um adaptador e inseriu na tomada de 3 pinos");
cabo3Pinos.ReceberEnergia3Pinos();
cabo3Pinos.EnergizarMaisPotente();