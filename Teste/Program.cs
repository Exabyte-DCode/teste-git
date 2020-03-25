using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello Git!!");
                Console.WriteLine("Good Night!");
            }

            DateTime actualTime = DateTime.Now.ToUniversalTime();
            Console.WriteLine("UTC time: " + actualTime);
           
        }
    }
}
