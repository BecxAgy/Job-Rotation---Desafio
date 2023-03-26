using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Rotation___Desafio.Solucoes
{
    public static class Solucao
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Questao1()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);

        }

        public static void Questao2()
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 1;

            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if (c == num)
            {
                Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número informado não pertence à sequência de Fibonacci.");
            }
        }

        public static void Questao4()
        {
            const int distancia = 100; // distância entre as cidades em km
            const int velocidadeCarro = 110; // velocidade do carro em km/h
            const int velocidadeCaminhao = 80; // velocidade do caminhão em km/h
            const double pedagioCaminhao = 0.083; // tempo em horas que o caminhão leva para passar em cada pedágio

            // tempo que o carro leva para chegar ao ponto de encontro
            double tempoCarro = distancia / (double)(velocidadeCarro);

            // tempo que o caminhão leva para chegar ao ponto de encontro
            double tempoCaminhao = distancia / (double)(velocidadeCaminhao);
            tempoCaminhao += 2 * pedagioCaminhao; // soma o tempo gasto nos dois pedágios

            // calcula a distância que cada veículo percorre até o ponto de encontro
            double distanciaCarro = velocidadeCarro * tempoCarro;
            double distanciaCaminhao = velocidadeCaminhao * tempoCaminhao;

            // verifica qual veículo está mais próximo da cidade de Ribeirão Preto
            if (distanciaCarro < distanciaCaminhao)
            {
                Console.WriteLine("O carro está mais próximo da cidade de Ribeirão Preto.");
            }
            else if (distanciaCaminhao < distanciaCarro)
            {
                Console.WriteLine("O caminhão está mais próximo da cidade de Ribeirão Preto.");
            }
            else
            {
                Console.WriteLine("O carro e o caminhão estão equidistantes da cidade de Ribeirão Preto.");
            }

            Console.ReadLine();
        }

        public static void Questao5()
        {
            string palavra = "Sou ideal para essa vaga ):"; // string que será invertida
            char[] caracteres = palavra.ToCharArray(); // Transformando a string em um array de caracteres

            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim) // Laço de repetição para inverter os caracteres
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;

                inicio++;
                fim--;
            }

            string resultado = new string(caracteres); // Conversão do array de caracteres de volta para uma string

            Console.WriteLine(resultado); 
        }
    }
}
   

