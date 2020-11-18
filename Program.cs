using System;

namespace Desafio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,... Pesquise como funciona o algoritmo Fibonacci. Faça um programa que gere a série até que o valor seja maior que 500.
            Console.WriteLine("SEQUÊNCIA DE FIBONACCI");
            Console.WriteLine("Escolha a quantidade de números desejadas:");
            int quant = int.Parse(Console.ReadLine());

            int anterior= 0;
            int atual=1;
            int proximo=1;
            int contador=0;

            while(contador < quant){
                Console.WriteLine(proximo);

                contador = contador+1;
                proximo= atual + anterior;
                anterior= atual;
                atual=proximo;
                
            }
        }
    }
}
