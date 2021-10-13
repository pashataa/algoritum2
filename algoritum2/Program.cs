using System;

namespace algoritum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a != b)
            {
                if (a > b)    
                {
                    a = a - b;

                   
                }
                else
                {
                    b = b - a;
                }
                Console.WriteLine("най голям общ делител е:" + a);
            }
            
        }
    }
}
