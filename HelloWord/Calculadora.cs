using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraCMD

{
    class Calculadora
    {

        enum Menu { Soma =1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}
        static void Main(string[] args) 
        {
            
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                //Exiba o menu


                Console.WriteLine("Seja bem vindo a calculadora CMD, selecione uma das opções," +
                    " aperte ENTER para continuar e fazer as operações. \n");
                //Console.WriteLine("");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplcao\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Somar();
                        break;
                    case Menu.Subtracao:
                        Subtrair();
                        break;
                    case Menu.Divisao:
                        Dividir();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;    
                }
             
                Console.Clear();
            }
         
        }

        static void Somar()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;

            Console.WriteLine($"o resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtrair()
        {
            Console.WriteLine("Subtrair dois números: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a - b;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Dividir()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            float resultado = (float)a/(float)b;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a * b;

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potencia de um números: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum,expo);
            

            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Potencia de um número: ");
            Console.WriteLine("Digite a base: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = (int)Math.Sqrt(a);


            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
