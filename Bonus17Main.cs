using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bonus17
{
    class FormatException : SystemException
    {
        static void Main(string[] args)
        {
            Cars c1 = new Cars("Honda", "Accord", 2019, 23959.90);
            Cars c2 = new Cars("Mercedes", "CLK350", 2019, 39787.90);
            Cars c3 = new Cars("Nissan", "Pathfinder", 2019, 39678.90);
            UsedCars a1 = new UsedCars("Hyonda", "Prior", 2017, 14450.00, 35987.6);
            UsedCars a2 = new UsedCars("GC", "Chirpus", 2013, 8500.00, 12345.0);
            UsedCars a3 = new UsedCars("GC", "Witherell", 2016, 14450.00, 3500.3);


            List<Cars> ncars = new List<Cars>();
            ncars.Add(c1);
            ncars.Add(c2);
            ncars.Add(c3);
            ncars.Add(a1);
            ncars.Add(a2);
            ncars.Add(a3);

            Console.WriteLine("Current Inventory:");
           
            for (int i = 0; i <= 5; i++)
            {
                int j = i + 1;
                Cars nn = ncars[i];
                Console.WriteLine($"{j}.{ncars[i]}");
            }
            Console.WriteLine("7. Quit");

            bool conti = true;
            while (conti)
            {
                
                Console.WriteLine("\nWhich car would you like?");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 0 && input <= ncars.Count)
                {
                    Cars full = ncars[input - 1];
                    Console.WriteLine(full.Make + "\t" + full.Model + "\t" + full.Price.ToString("C2", CultureInfo.CurrentCulture) + "\t" + full.Year);
                    conti = true;

                    Console.WriteLine("Would you like to buy this car? (enter yes or no):");
                    string response = Console.ReadLine();

                    if (response == "Yes" || response == "yes" || response == "YES")
                    {

                        Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
                        ncars.RemoveAt(input - 1);
                        for (int i = 0; i <= 4; i++)
                        {
                            int j = i + 1;
                            //Cars ok = ncars[i];
                            Console.WriteLine($"{j}.{ncars[i]}");
                        }
                        Console.WriteLine("6. Quit");

                    }
                    else
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            int j = i + 1;
                            Cars ok = ncars[i];
                            Console.WriteLine($"{j}.{ncars[i]}");
                        }
                        Console.WriteLine("7. Quit");
                    }
                    
                }
                else if (input == 7)
                {
                    conti = false;
                }
                else
                {
                    conti = false;
                }

            }
            Console.WriteLine("Have a great day!");

        }
        }
    }


