using Prototype.Models;

GerenciadorDeVitor gerenciadorDeVitor = new GerenciadorDeVitor();

gerenciadorDeVitor["padrão"] = new VitorConcreto("corpo de vitor", "mente de vitor");
gerenciadorDeVitor["personalizada"] = new VitorConcreto("corpo de vitor saudavel", "mente de vitor triste");

VitorConcreto clone = gerenciadorDeVitor["padrão"].clone() as VitorConcreto;
VitorConcreto clone2 = gerenciadorDeVitor["personalizada"].clone() as VitorConcreto;