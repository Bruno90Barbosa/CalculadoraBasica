using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {

        enum Menu {Soma=1, Subtração, Divisão, Multiplicação, Potência, Raiz, Sair}

        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("CALCULADORA DE OPERAÇÕES BÁSICAS");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");

                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Console.WriteLine("");
                Menu op = (Menu)int.Parse(Console.ReadLine());


                /*SWITCH utilizado para gerar resultados conforme a solicitação do usúario. Para cada solicitação, 
                 uma função sera executada para realizar a operação*/
                switch (op)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtração:
                        Sub();
                        break;

                    case Menu.Divisão:
                        Div();
                        break;

                    case Menu.Multiplicação:
                        Mult();
                        break;

                    case Menu.Potência:
                        Pot();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        exit = true;
                        break;
                }

                Console.Clear();
            }
            
        }

        /*Função responsável por realizar a SOMA entre os números, caso o usuário selecione a opção 1*/
        static void Soma()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Soma de dois números:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int resultado = a + b;
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: { resultado}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }

        /*Função responsável por realizar a SUBTRAÇÃO entre os números, caso o usuário selecione a opção 2*/
        static void Sub()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Subtração de dois números:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número: ");
            int aSub = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int bSub = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int resultadoSub = aSub - bSub;
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: {resultadoSub}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }

        /*Função responsável por realizar a DIVISÃO entre os números, caso o usuário selecione a opção 3*/
        static void Div()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Divisão de dois números:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número: ");
            int aDiv = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int bDiv = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            float resultadoDiv = (float)aDiv / (float)bDiv;
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: {resultadoDiv}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }

        /*Função responsável por realizar a MULTIPLICAÇÃO entre os números, caso o usuário selecione a opção 4*/
        static void Mult()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Multiplicação de dois números:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número: ");
            int aMult = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int bMult = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int resultadoMult = aMult * bMult;
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: {resultadoMult}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }

        /*Função responsável por realizar a POTÊNCIA entre os números, caso o usuário selecione a opção 5*/
        static void Pot()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Potência de um número:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite a base: ");
            int aBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int bExp = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int resultadoPot = (int)Math.Pow( aBase, bExp);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: {resultadoPot}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }

        /*Função responsável por realizar a RAIZ do número, caso o usuário selecione a opção 6*/
        static void Raiz()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Raiz de dois números:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite o primeiro número: ");
            int aRaz = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            double resultadoRaz = Math.Sqrt(aRaz);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"O resultado é: {resultadoRaz}");
            Console.WriteLine("Aperte ENTER e retorne ao menu.");
            Console.WriteLine("--------------------------------");
            Console.ReadLine();

        }


    }
}
