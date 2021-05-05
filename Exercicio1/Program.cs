using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicao= false;
            Console.WriteLine("Digite sua nota para que seja registrada no sistema:");
            float nota = float.Parse(Console.ReadLine());
            
            Console.WriteLine();

            while (condicao==false){
                if(nota >= 0 && nota<=10){
                    Console.WriteLine("Nota validada e registrada. Finalizando o sistema...");
                    condicao= true;
                }
                else{
                    Console.WriteLine("Nota inválida, digite novamente.");
                    nota = float.Parse(Console.ReadLine());
                    condicao= false;
                }
            }
        }
    }
}
