using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{
    internal class Game
    {
        public enum resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };
        
        public Image imgPc {  get; private set; }
        public Image imgJogador {  get; private set; }

        public resultado Jogar(int jogador)
        {
            int pc = JogadaPc();

            imgJogador = images[jogador];
            imgPc = images[pc];

            if(jogador == pc)
            {
                return resultado.Empatar;
            } else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return resultado.Ganhar;
            }
            else
            {
                return resultado.Perder;
            }

            
        }

        private int JogadaPc()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if(mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}
