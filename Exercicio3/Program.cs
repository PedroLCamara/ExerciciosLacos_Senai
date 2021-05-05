using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool denovo = false;
            do
            {
                bool nomeCondicao = false;
                bool idadeCondicao = false;
                bool salarioCondicao = false;
                bool estadoCivilCondicao = false;
               while(nomeCondicao==false){
                    Console.WriteLine("Digite seu nome");
                    string nome= Console.ReadLine();
                    if(nome==""){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nome inválido, digite novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        nomeCondicao = false;
                        Console.WriteLine();
                    }
                    else{
                        nomeCondicao = true;
                        Console.WriteLine();
                    }
               }
               while(idadeCondicao==false){
                    Console.WriteLine("Digite sua idade");
                    int idade= int.Parse(Console.ReadLine());
                    if(idade>=0 && idade<=150){
                        idadeCondicao= true;
                        Console.WriteLine();
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Idade inválida, digite novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        idadeCondicao = false;
                        Console.WriteLine();
                    }
               }
               while(salarioCondicao==false){
                    Console.WriteLine("Digite seu salário");
                    int salario= int.Parse(Console.ReadLine());
                    if(salario > 0){
                        salarioCondicao= true;
                        Console.WriteLine();
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Salário inválido, digite novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                        salarioCondicao = false;
                        Console.WriteLine();
                    }
               }
               while(estadoCivilCondicao==false){
                    Console.WriteLine("Digite seu estado civil (c/s/v/d)");
                    string estadoCivilDados= Console.ReadLine().ToLower();
                    string estadoCivil= estadoCivilDados.Substring(0,1);
                    switch (estadoCivil)
                    {
                        case "c":
                            estadoCivilCondicao= true;
                            Console.WriteLine();
                            break;
                        case "s":
                            estadoCivilCondicao= true;
                            Console.WriteLine();
                            break;
                        case "v":
                            estadoCivilCondicao= true;
                            Console.WriteLine();
                            break;
                        case "d":
                            estadoCivilCondicao= true;
                            Console.WriteLine();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Estado civil inválido, digite novamente.");
                            Console.ForegroundColor = ConsoleColor.White;
                            estadoCivilCondicao = false;
                            Console.WriteLine();
                            break;
                    }
               }
                Console.WriteLine("Cadastro realizado. Deseja realizar outro cadastro?(s/n)");
                string resposta = Console.ReadLine().ToLower();
                if(resposta=="s"){
                    denovo= true;
                    Console.WriteLine();
                } 
                else{
                    Console.WriteLine("Tudo bem. Finalizando o sistema...");
                    denovo= false;
                }
            } while (denovo==true);

            
        }
    }
}