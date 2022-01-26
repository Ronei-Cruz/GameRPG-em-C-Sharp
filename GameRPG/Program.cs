using System;
using GameRPG.src.Models;

namespace GameRPG.src.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos jogar?");
            string? opcao = Menu(); 
            if(opcao == "1")
            {
                int experience1 = 100;
                int experience2 = 100;
                int number = 1;

                string? resposta = ContinueGame();
                while(resposta == "S")
                {
                    Knight warrior = new Knight("Morfus","Guerreiro", experience1);
                    Wizard mage = new Wizard("Leona", "Mago", experience2);
                    Console.WriteLine("\t------ Rodada " + number + " ------\n");
                    Console.WriteLine("Seu personagem:");
                    Console.WriteLine(warrior);
                    Console.WriteLine("\nSeu oponente:");
                    Console.WriteLine(mage);
                    Console.WriteLine("=======");
                    int live = warrior.Attack();
                    int live2 = mage.Attack();
                    Console.WriteLine("=======");
                    experience1 = warrior.Damage(live2);
                    experience2 = mage.Damage(live);
                    Console.WriteLine("=======");
                    Console.WriteLine("Depois dos ataques!");
                    Console.WriteLine(mage);
                    Console.WriteLine("=======");
                    Console.WriteLine(warrior);
                    
                    if(mage.Experience <= 0)
                    {
                        Console.WriteLine("\n\tVOCÊ GANHOU");
                        break;
                    }
                    else if (warrior.Experience <= 0)
                    {
                        Console.WriteLine("\n\tVOCÊ PERDEU, SEU ATAQUE FOI FRACO!");
                        break;
                    }
                    else if (mage.Experience == 0 && warrior.Experience == 0)
                    {
                        Console.WriteLine("\n\tDEU EMPATE!");
                        break;
                    }
                    Console.WriteLine("Quer continuar o jogo?");
                    resposta = ContinueGame();
                    number += 1;
                }
                Console.WriteLine("Obrigado por jogar!");
            }
            else if(opcao == "2")
            {
                int experience1 = 100;
                int experience2 = 100;
                int number = 1;

                string? resposta = ContinueGame();
                while(resposta == "S")
                {
                    Knight warrior = new Knight("Morfus","Guerreiro", experience1);
                    Wizard mage = new Wizard("Leona", "Mago", experience2);
                    Console.WriteLine("\t------ Rodada " + number + " ------\n");
                    Console.WriteLine("Seu personagem:");
                    Console.WriteLine(mage);
                    Console.WriteLine("\nSeu oponente:");
                    Console.WriteLine(warrior);
                    Console.WriteLine("=======");
                    int live = warrior.Attack();
                    int live2 = mage.Attack();
                    Console.WriteLine("=======");
                    experience1 = warrior.Damage(live2);
                    experience2 = mage.Damage(live);
                    Console.WriteLine("=======");
                    Console.WriteLine("Depois dos ataques!");
                    Console.WriteLine(mage);
                    Console.WriteLine("=======");
                    Console.WriteLine(warrior);
                    
                    if(mage.Experience <= 0)
                    {
                        Console.WriteLine("\n\tVOCÊ GANHOU");
                        break;
                    }
                    else if (warrior.Experience <= 0)
                    {
                        Console.WriteLine("\n\tVOCÊ PERDEU, SEU ATAQUE FOI FRACO!");
                        break;
                    }
                    else if (mage.Experience == 0 && warrior.Experience == 0)
                    {
                        Console.WriteLine("\n\tDEU EMPATE!");
                        break;
                    }
                    Console.WriteLine("Quer continuar o jogo?");
                    resposta = ContinueGame();
                    number += 1;
                }
                Console.WriteLine("Obrigado por jogar!");
            }              
     
        }
        public static string? Menu()
        {
            Console.WriteLine("Escola seu personagem:");
            Console.WriteLine("[1] - Guerreiro\n[2] - Mago");

            string? opcao = Console.ReadLine();
            return opcao;
        }

        public static string? ContinueGame()
        {
            Console.WriteLine("Quer jogar? [S] - SIM [N] - NÃO");
            string? resposta = Console.ReadLine().ToUpper();

            return resposta;
        }
    }
}