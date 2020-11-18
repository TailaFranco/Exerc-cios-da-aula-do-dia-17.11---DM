using System;

namespace Aula_17._11
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Nesta atividade está todos os exercícios realizados no dia 17/11/2020.
            //Para visualizar qualquer um deles utilize os comandos de comentar e descomentar e dotnet run para executar.
            // Ctrl + k + c == comentar
            // Ctrl + k + u == descomentar


            // Primeiro exercício Menu de Opções bebidas
            // string gelo = "";
            // Console.WriteLine("Menu de opções");
            // Console.WriteLine("Escolha uma opção de bebida abaixo");
            // Console.WriteLine("1 - Coca Cola");
            // Console.WriteLine("2 - Pepsi");
            // Console.WriteLine("3 - Fanta");
            // Console.WriteLine("4 - Água");
            // int resposta = int.Parse(Console.ReadLine());
            // if (resposta > 0 && resposta <5)
            // {
            //     Console.WriteLine("Você gostaria da sua bebida com gelo? Sim ou Não");
            //     gelo = Console.ReadLine();
            // }

            // switch (resposta)
            // {
            //     case 1:
            //     if(gelo == "Sim")
            //     {
            //         Console.WriteLine("Será enviado uma Coca Cola com cubos de gelo para sua mesa.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Será enviado uma Coca Cola sem cubos de gelo para sua mesa.");
            //     }
            //         break;

            //     case 2:
            //     if(gelo == "Sim")
            //     {
            //         Console.WriteLine("Será enviado uma Pepsi com cubos de gelo para sua mesa.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Será enviado uma Pepsi sem cubos de gelo para sua mesa.");
            //     }
            //         break;
                
            //     case 3:
            //     if(gelo == "Sim")
            //     {
            //         Console.WriteLine("Será enviado uma Fanta com cubos de gelo para sua mesa.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Será enviado uma Fanta sem cubos de gelo para sua mesa.");
            //     }
            //         break;
                
            //     case 4:
            //     if(gelo == "Sim")
            //     {
            //         Console.WriteLine("Será enviado uma água gelada para sua mesa.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Será enviado uma água para sua mesa.");
            //     }
            //         break;

            //     default:
            //         Console.WriteLine("Opção Inválida");
            //         break;
            // }
            //Fim do Primeiro exercício
            
            //Segundo Exercício adivinhar a Idade do ator utilizando a função while
            // Console.WriteLine("Digite a idade do ator");
            // int idade = int.Parse(Console.ReadLine());

            // while(idade != 47)
            // {
            //     Console.WriteLine("Errou");
            //     Console.WriteLine("Digite a idade do ator novamente");
            //     idade = int.Parse(Console.ReadLine());
            // }
            //     Console.WriteLine("Acertou miseravi");
            // Fim do segundo exercício

            //Terceiro exercício - Adivinhar a idade do ator usando a função do while.
            // int idade;
            // do
            // {
            // Console.WriteLine("Digite a idade do ator");
            // idade = int.Parse(Console.ReadLine());
            // }
            // while(idade != 47);
            // Console.WriteLine("Acertou miseravi");
            // Fim do terceiro exercício

        //Quarto exercício Realizar a tabuada até 10 de um número digitado.
           int numero;
           int tabuada;
            int resultado;
            Console.WriteLine("Exercício Tabuada \n Digite um número para calcular a sua tabuada até 10");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada do "+numero+"");
            tabuada = 0;
            while(tabuada <=10){
                resultado = numero * tabuada;
                Console.WriteLine(""+numero+" * "+tabuada+" = "+resultado+"");
                tabuada = tabuada +1;
                                }
        //Fim do Quarto exercício 
            
        }
    }
}
