using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeysJohan
{
    class Program
    {
        static void Main(string[] args)
        {
            //new games

            List<int> x = new List<int>();
            List<string> symbol = new List<string>();
            string Simber = "0";
            while (Simber != "=")
            {
                Console.WriteLine("Input Number");
                Regex r = new Regex("^[0-9]+$");
                string Number1 = Console.ReadLine();
                while (r.IsMatch(Number1) != true)
                {
                    Console.WriteLine("Input Number Ps");
                    Number1 = Console.ReadLine();
                }
                x.Add(int.Parse(Number1));
                Console.WriteLine("Input Symbol");
                Regex s = new Regex("^[+/*=-]{1}$");
                Simber = Console.ReadLine();
                while (s.IsMatch(Simber) != true)
                {
                    Console.WriteLine("Input Symbol Ps");
                    Simber = Console.ReadLine();
                }
                symbol.Add(Simber);
                if (Simber == "=")
                {
                    Console.WriteLine("Andwoord");
                    Console.WriteLine();
                }
            }
            for (int n = 0; n < x.Count(); n++)
            {
                Console.Write($"{x[n]} {symbol[n]} ");
            }
           
            List<int> antwoord = new List<int>();
            antwoord.Add(x[0]);
            for (int j = 0; j < x.Count(); j++)
            {
                switch (symbol[j])
                {
                    case "+":
                        antwoord.Add(_ = antwoord[j] + x[j + 1]);
                        break;
                    case "-":
                        antwoord.Add(_ = antwoord[j] - x[j + 1]);
                        break;
                    case "*":
                        antwoord.Add(_ = antwoord[j] * x[j + 1]);
                        break;
                    case "/":
                        antwoord.Add(_ = antwoord[j] / x[j + 1]);
                        break;
                    case "=":
                        Console.WriteLine(antwoord[j]);
                        //Console.WriteLine("Chantel");
                        break; 
                }

            }

        }
    }
}
