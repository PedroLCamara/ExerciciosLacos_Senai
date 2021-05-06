using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {  
                int numeroAnterior2= 0;
                int numeroAnterior= 1;
                int numero= numeroAnterior2 + numeroAnterior;
                Console.WriteLine(+numero);
                for (var i = 0; i <= 500; i=numero)
                {
                    numero= numeroAnterior+numeroAnterior2;
                    numeroAnterior2= numeroAnterior;
                    numeroAnterior = numero;
                    Console.WriteLine(+numero);
                }
        }     
    }
}
