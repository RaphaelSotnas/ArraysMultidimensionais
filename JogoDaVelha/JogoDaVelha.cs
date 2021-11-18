using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class JogoDaVelha
    {
        //Preciso criar as etapas de um jogo e pensar na lógica para que ele aconteça

        private bool fimDeJogo;
        private string[] posicoes;
        private string vez;
        private int quantidadeDeJogadas = 0;

        public JogoDaVelha()
        {
            fimDeJogo = false;
            posicoes = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            vez = "X";
        }

        public void iniciarJogo()
        {
            //Enquanto o fim de jogo não chega, o que deve ser feito?
            while (!fimDeJogo)
            {
                //Preciso atualizar a tabela para que o meu jogador escolha um número para começar o jogo.
                AtualizarTabela();

                //Após isso, preciso ler a escolha que ele fez 
                LerEscolhaDoJogador();

                //Depois disso eu mostro a tabela com o valor escolhido.
                AtualizarTabela();

                //Verificar Se alguém ganhou o game.
                VerificarVencedor();

                //Dar a vez ao outro jogador
                MudarVez();

            }

            Console.WriteLine("Temos um vencedor! Parabéns!");
        }

        private void MudarVez()
        {
            if(vez == "X")
            {
                vez = "O";
            }
            else
            {
                vez = "X";
            }
        }

        private void VerificarVencedor()
        {
            VencedorLinha();
            VencedorColuna();
            VencedorInclinado();
            if (VencedorLinha()== true || VencedorColuna() || VencedorInclinado() == true)
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de jogo! Vitória do {vez}");
            }

            if(quantidadeDeJogadas == 9)
            {
                fimDeJogo = true;
                Console.WriteLine("EMPATE! Tente novamente");
            }

        }

        private bool VencedorLinha()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[1] == posicoes[2];
            bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[4] == posicoes[5];
            bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[7] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        private bool VencedorColuna()
        {
            bool vitoriaColuna1 = posicoes[0] == posicoes[3] && posicoes[3] == posicoes[6];
            bool vitoriaColuna2 = posicoes[1] == posicoes[4] && posicoes[4] == posicoes[7];
            bool vitoriaColuna3 = posicoes[2] == posicoes[5] && posicoes[5] == posicoes[8];
            return vitoriaColuna1 || vitoriaColuna2 || vitoriaColuna3;

        }

        private bool VencedorInclinado()
        {
            bool vitoriaInclinado1 = posicoes[0] == posicoes[4] && posicoes[4] == posicoes[8];
            bool vitoriaInclinado2 = posicoes[2] == posicoes[4] && posicoes[4] == posicoes[6];
            return vitoriaInclinado1 || vitoriaInclinado2;

        }

        private void LerEscolhaDoJogador()
        {
            Console.WriteLine($"Agora é a vez de {vez} jogar, escolha um número disponível na tabela.");
            int escolha = Convert.ToInt32(Console.ReadLine());
            int numeroNoArray = escolha - 1;
            posicoes[numeroNoArray] = vez;
            quantidadeDeJogadas++;
;       }

        private void AtualizarTabela()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());

        }
        private string ObterTabela()
        {
            return $"___{posicoes[0]}__|___{posicoes[1]}__|___{posicoes[2]}__\n" +
                   $"___{posicoes[3]}__|___{posicoes[4]}__|___{posicoes[5]}__\n" +
                   $"___{posicoes[6]}__|___{posicoes[7]}__|___{posicoes[8]}__\n";
        }
    }
}
