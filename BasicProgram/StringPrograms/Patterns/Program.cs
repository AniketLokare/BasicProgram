using System;

namespace Patterns
{
    class Program
    {
        //1
        //1 2
        //1 2 3
        public void Pattern1()
        {
            Console.WriteLine("Enter the line values");
            int length1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length1; j++)
                { 
                    if (i >= j)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Press key..");
            Console.ReadKey();
        }

            //1
          //321
         //4321
        //54321
        public void Pattern2()
        {
            Console.WriteLine("Enter the line values");
            int length1 = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= length1; j++)
            {
                for (int i = length1; i >= 1; i--)
                {
                    if (i>j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Press key..");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Pattern2();
            
        }
    }
}