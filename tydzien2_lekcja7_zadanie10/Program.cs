using System;

namespace tydzien2_lekcja7_zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int a = 40;
            int b = 55;
            int c = 65;

            if (c < a + b) 
            Console.WriteLine("Można zbudować trójkąt");
            else
                Console.WriteLine("Nie można zbudować trójkąta");

            Console.ReadKey();

        }
    }
}
