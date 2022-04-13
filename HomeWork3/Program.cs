using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("bir soz daxil edin");
           string names = Console.ReadLine();
            if (names.Length >= 5) 
            {
                Console.WriteLine(names.Length);
            }
            else if (names.Length < 5)
            {
                Console.WriteLine("sozler 5 herfi kecmir");
            }

        }
    }
}
