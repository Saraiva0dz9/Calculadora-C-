﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu(){
            Console.Clear();

            Console.WriteLine("Ola seja bem vindo!!");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

             switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: PerguntaDeAvaliação(); break;
                default: Menu(); break;
             }
        }

        static void PerguntaDeAvaliação(){
               Console.Clear();
               Console.WriteLine("Gostou dessa aplicação?");
               Console.WriteLine("1 - Sim");
               Console.WriteLine("2 - Não");
               int v1 = int.Parse( Console.ReadLine());
                
                if (v1 == 1) {
                    Console.WriteLine("Obrigado!");
                    Thread.Sleep(2000);
                    MensagemDeConfirmação();
                }

                else;

                    Console.WriteLine("Obrigado!");
                    Thread.Sleep(2000);
                    MensagemDeConfirmação();
        }

        static void MensagemDeConfirmação() { 
               Console.Clear();
               Console.WriteLine("Tem certeza que deseja sair da aplicação?");
               Console.WriteLine("1 - Sim");
               Console.WriteLine("2 - Não");
               int v1 = int.Parse( Console.ReadLine());
                
                if (v1 == 1) {
                    
                    Console.WriteLine("Obrigado por ultilizar a aplicação!!");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                }

                else;

                    Menu();
               


        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
             
            float resultado = v1 + v2;
            Console.WriteLine("O resultado do soma é " + resultado );
            Console.ReadKey();
            Menu();
        }

            static void Subtracao(){
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 - v2;
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
                Menu();
            }

            static void Divisao(){
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 / v2;
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
                Menu();
            }

            static void Multiplicacao(){
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 * v2;
                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
                Menu();
                
            }
    }        
}