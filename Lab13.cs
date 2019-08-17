using System;

namespace Lab13
{
	class Program
	{

		static void Main(string[] args)
		{

			int randomInt;

			Console.WriteLine("Welcome to Rock Paper Scissors!");
			Console.WriteLine("Enter your name:");

			string name = Console.ReadLine();

			Console.WriteLine("Would you like to play against TheJets or TheSharks (j/s)?");
			string user = Console.ReadLine();



            if (user == "j")
            {
                bool cont = true;
                while (cont)
                {
                    Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
                    string input = Console.ReadLine();




                    Console.WriteLine("TheJets: rock");
                    if (input == "r")
                    {
                        Console.WriteLine($"{name}: rock");
                        Console.WriteLine("Draw!");
                    }
                    else if (input == "p")
                    {
                        Console.WriteLine($"{name}: paper");
                        Console.WriteLine($"{name} wins!");

                    }
                    else if (input == "s")
                    {
                        Console.WriteLine($"{name}: scissors");
                        Console.WriteLine("TheJets wins!");

                    }
                    Console.WriteLine("Play again? (yes/no):");
                    string option = Console.ReadLine();

                    if (option == "Yes" || option == "yes" || option == "YES")
                    {
                        cont = true;
                    }
                    else if (option == "No" || option == "no" || option == "NO")
                    {
                        cont = false;
                        Console.WriteLine("Thank you for playing.");
                    }
                }
            }


            else if (user == "s")
            {
                bool cont1 = true;
                while (cont1)
                {
                    
                    Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
                    string input = Console.ReadLine();

                    Random Roshambo = new Random();
                    randomInt = Roshambo.Next(1, 3);
                    switch (randomInt)
                    {
                        case 1:
                            Console.WriteLine("TheSharks: rock");
                            if (input == "r")
                            {
                                Console.WriteLine($"{name}: rock");
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (input == "p")
                            {
                                Console.WriteLine($"{name}: paper");
                                Console.WriteLine($"{name} wins!\n\n");
                            }
                            else if (input == "s")
                            {
                                Console.WriteLine($"{name}: scissors");
                                Console.WriteLine("TheSharks win!\n\n");
                            }
                            break;
                        case 2:
                            Console.WriteLine("TheSharks: paper");
                            if (input == "p")
                            {
                                Console.WriteLine($"{name}: paper");
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (input == "s")
                            {
                                Console.WriteLine($"{name}: scissors");
                                Console.WriteLine($"{name} wins!\n\n");
                            }
                            else if (input == "r")
                            {
                                Console.WriteLine($"{name}: rock");
                                Console.WriteLine("TheSharks win!\n\n");
                            }
                            break;
                        case 3:
                            Console.WriteLine("TheSharks: paper");
                            if (input == "s")
                            {
                                Console.WriteLine($"{name}: scissors");
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (input == "r")
                            {
                                Console.WriteLine($"{name}: rock");
                                Console.WriteLine($"{name} wins!\n\n");
                            }
                            else if (input == "p")
                            {
                                Console.WriteLine($"{name}: paper");
                                Console.WriteLine("TheSharks win!\n\n");
                            }


                            break;
                        default:
                            Console.WriteLine("Sorry, that option is invalid. Try again!");
                            break;
                    }
                            Console.WriteLine("Play again? (yes/no):");
                            string option = Console.ReadLine();

                            if (option == "Yes" || option == "yes" || option == "YES")
                            {
                                cont1 = true;
                            }
                            else if (option == "No" || option == "no" || option == "NO")
                            {
                                cont1 = false;
                                Console.WriteLine("Thank you for playing.");
                            }
                    
                }
            }




					}











				}
				

			}

		

