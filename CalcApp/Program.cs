using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running == true)
            { 
                //Console.WriteLine("1: addition 2: Subtraction");
                //int route = int.Parse(Console.ReadLine());
                int route = Menu();
                switch (route)
                {
                    case 1:


                        int a = new int();
                        int b = new int();

                        Console.WriteLine("Tal 1:");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("et tal, tak");
                            goto case 1;
                        }

                        Console.WriteLine("Tal 2:");
                        try
                        {
                            b = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("et tal, tak");
                            goto case 1;
                        }

                        int v = Calculator.Add(a, b);

                        Console.WriteLine("resultatet er: " + v);
                        Console.ReadLine();


                        break;

                    case 9:
                        running = false;
                        break;
                }
            }

                        

        }

        static int Menu()
        { 
            int a = new int();
            Console.WriteLine("1: addition\n\r2: Subtraktion\n\r9: Exit");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("prøv igen");
            }

            return a;
        }
    }
}
