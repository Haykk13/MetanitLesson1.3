using System;

namespace MetanitLesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if(num == 5 || num == 10)
            {
                Console.WriteLine("Your integer is either 5 or 10!");
            }
            else
            {
                Console.WriteLine("Unknown integer");
            }

            Console.ReadLine();
        }
    }
}
