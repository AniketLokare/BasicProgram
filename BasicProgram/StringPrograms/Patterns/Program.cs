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

        // Print Floyd's traingle
        // 1
        // 2 3
        // 4 5 6
        // 7 8 9 10
        public void Pattern3()
        {
            Console.WriteLine("Enter the line values");
            int length1 = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= length1; i++)
            {
                for (int j = 1; j <= length1; j++)
                {
                    if (i>=j)
                    {
                        Console.Write(k +" ");
                        k++;
                    }
                   
                }
                Console.WriteLine(" ");
                
            }

            Console.WriteLine("Press key..");
            Console.ReadKey();
        }

        // Inverted half pyramid using *
        //*****
        //****
        //***
        //**
        //*
        public void Pattern4()
        {
            Console.WriteLine("Enter the line values");
            int length1 = Convert.ToInt32(Console.ReadLine());

            for (int i = length1; i >= 1; i--)
            {
                for (int j = 1; j <= length1; j++)
                {
                    if (j<i || j==i)
                    {
                        Console.Write("*");
                    }                   
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Press key..");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Pattern4();
            
        }
    }
}
