using FlyWeight.Models;

FlyWeightClasse flyWeight = new FlyWeightClasse();
Botao botao = flyWeight.GetBotao("vermelho");
Botao botao2 = flyWeight.GetBotao("verde");

Console.WriteLine("Esta ocorrendo uma explosão, pare ela imediatamente! Você quer apertar o botao verde ou vermelho?");

if (Console.ReadLine() == botao2.Cor)
{
    botao2.AcaoDoBotao();
}
else
{
    botao.AcaoDoBotao();
}