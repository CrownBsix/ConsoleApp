
using Aardvark.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
           
            //intialization
            bool IsPrime = true;

            Console.WriteLine("The First 100 Prime Numbers Are : ");
            
            for (int i = 2; i <= 545; i++)
            {
                
                for (int j = 2; j <= 545; j++)
                {
                    //Check if the number is prime
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }

                }
                if (IsPrime)
                {
                    //Print prime numbers
                    Console.Write("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadKey();
        }
    }

}
    

