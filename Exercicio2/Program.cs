using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicao = false;
            do
            {
                Console.WriteLine("Digite seu nome de usuário");
                string usuario = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite sua senha. P.S: Sua senha não pode ser igual ao nome de usuário");
                string senha = Console.ReadLine();
                
                Console.WriteLine();

                if(usuario != senha){
                    Console.WriteLine("Conta registrada, finalizando o sistema...");
                    condicao=true;
                }
                else{
                    Console.WriteLine("Conta inválida. A senha deve ser diferente do nome de usuário!");
                    condicao=false;
                    Console.WriteLine();
                }

            } while(condicao==false);
        }
    }
}
