using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many years of professional experience do you have");
            string input = Console.ReadLine();
            if(int.Parse(input) != 0)
            {
                for (int i = 1; i <= int.Parse(input); i++)
                {
                    Console.WriteLine("you have {0} number of year experience", i);

                }
            }
            else
            {
                Console.WriteLine("you have zero experience");
            }

            

        }
    }
}
