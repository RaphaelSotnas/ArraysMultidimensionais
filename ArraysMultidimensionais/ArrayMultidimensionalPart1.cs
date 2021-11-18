using System;

namespace ArraysMultidimensionais
{
    class ArrayMultidimensionalPart1
    {
        static void Main(string[] args)
        {
            AprendendoArraysMultidimencionais();
            JogoDaVelha();
        }

        public static void AprendendoArraysMultidimencionais()
        {
            //Declaro o tamanho da minha matriz na declaração do meu array(1)
            string[,] resultados = new string[4, 3];
            //{
            //Dessa maneira eu não consigo imprimir no console uma tabela de fato!(0)
            //Apenas continuo imprimindos times de maneira desordenada.
            //{ "Alemanha","Espanha","Itália"},
            //{ "Argentina","Holanda","França"},
            //{ "Alemanha","Holanda","Brasil" }


            //Se faz necessário setar todos os valores do meu array miltidimencional.(3)
            resultados[0, 0] = "Flamengo";
            resultados[1, 0] = "Fluminense";
            resultados[2, 0] = "Vasco";
            resultados[3, 0] = "Botafogo";



            resultados[0, 1] = "Atlético";
            resultados[1, 1] = "Palmeiras";
            resultados[2, 1] = "São Paulo";
            resultados[3, 1] = "Vasco";



            resultados[0, 2] = "Fortaleza";
            resultados[1, 2] = "Ceará";
            resultados[2, 2] = "Flamengo";
            resultados[3, 2] = "Fluminense";


            //Mesmo declarando o minha matriz, ainda estou com problemas em "Exibir" a minha tabela.(4)


            //}

            //Meu laço foreach não consegue exibir as informações da maneira como eu quero, por isso preciso colocar um laço for.(5)
            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int jogos = 0; jogos <= resultados.GetUpperBound(1); jogos++)
            {
                int ano = 2019 + jogos;
                //Como o meu resultado é um INT, preciso converter ele para uma string.(6)
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            //Para fazer com que a minha tabela seja exibida em forma de tabela(7)
            //Criei um laço de repetição para exibir meus jogos um abaixo do outro(8)
            //Coloquei meu 4º colocado na tabela.
            for (int time = 0; time <= resultados.GetUpperBound(0); time++)
            {
                for (int ano = 0; ano <= resultados.GetUpperBound(1); ano++)
                {
                    Console.Write(resultados[time, ano].PadRight(12));
                }
                Console.WriteLine();
            }

        }

        public static void JogoDaVelha()
        {
            string[,] tabuleiro = new string[3, 3];

            tabuleiro[0, 0] = "x";
            tabuleiro[1, 0] = " ";
            tabuleiro[2, 0] = "O";

            tabuleiro[0, 1] = "X";
            tabuleiro[1, 1] = "X";
            tabuleiro[2, 1] = "O";

            tabuleiro[0, 2] = " ";
            tabuleiro[1, 2] = "O";
            tabuleiro[2, 2] = "X";

            for (var coluna = 0; coluna <= tabuleiro.GetUpperBound(0); coluna++)
            {
                for (var linha = 0; linha <= tabuleiro.GetUpperBound(1); linha++)
                {
                    Console.Write(tabuleiro[linha, coluna].PadRight(2));
                }
                Console.WriteLine();
            }
        }

    }

}
