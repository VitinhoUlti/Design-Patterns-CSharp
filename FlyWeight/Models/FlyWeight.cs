using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyWeight.Models
{
    public class FlyWeightClasse
    {
        private Dictionary<string, Botao> ListaDeBotoes = new Dictionary<string, Botao>();
        public Botao GetBotao(string cor)
        {
            Botao botao = null;

            if (ListaDeBotoes.ContainsKey(cor))
            {
                botao = ListaDeBotoes[cor];
            }
            else
            {
                switch (cor)
                {
                    case "vermelho":
                        botao = new BotaoDaDestruicao("vermelho");
                        break;
                    case "verde":
                        botao = new BotaoParaPararDestruicao("verde");
                        break;
                }
                ListaDeBotoes.Add(cor, botao);
            }
            return botao;
        }
    }
}