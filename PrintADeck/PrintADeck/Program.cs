﻿using System;

namespace PrintADeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string curentCard = Console.ReadLine();
            int endCard = 0;
            switch (curentCard)
            {
                case "2":
                    endCard = 2;
                    break;
                case "3":
                    endCard = 3;
                    break;
                case "4":
                    endCard = 4;
                    break;
                case "5":
                    endCard = 5;
                    break;
                case "6":
                    endCard = 6;
                    break;
                case "7":
                    endCard = 7;
                    break;
                case "8":
                    endCard = 8;
                    break;
                case "9":
                    endCard = 9;
                    break;
                case "10":
                    endCard = 10;
                    break;
                case "J":
                    endCard = 11;
                    break;
                case "Q":
                    endCard = 12;
                    break;
                case "K":
                    endCard = 13;
                    break;
                case "A":
                    endCard = 14;
                    break;
            }

            for (int card = 2; card <= endCard; card++)
            {

                for (int color = 0; color < 4; color++)
                {
                    switch (card)
                    {
                        case 2:
                            Console.Write("2");
                            break;
                        case 3:
                            Console.Write("3");
                            break;
                        case 4:
                            Console.Write("4");
                            break;
                        case 5:
                            Console.Write("5");
                            break;
                        case 6:
                            Console.Write("6");
                            break;
                        case 7:
                            Console.Write("7");
                            break;
                        case 8:
                            Console.Write("8");
                            break;
                        case 9:
                            Console.Write("9");
                            break;
                        case 10:
                            Console.Write("10");
                            break;
                        case 11:
                            Console.Write("J");
                            break;
                        case 12:
                            Console.Write("Q");
                            break;
                        case 13:
                            Console.Write("K");
                            break;
                        case 14:
                            Console.Write("A");
                            break;
                    }
                    switch (color)
                    {
                        case 0:
                            Console.Write(" of spades, ");
                            break;
                        case 1:
                            Console.Write(" of clubs, ");
                            break;
                        case 2:
                            Console.Write(" of hearts, ");
                            break;
                        case 3:
                            Console.WriteLine(" of diamonds");
                            break;
                    }

                }
            }
        }
    }
}

