using System;
using static System.Console;
namespace Lesson_3
{
    class Program
    {
        
        public class PrimeFactors
        {
            public static int PrimeValue(int x)
            {
               if( x == 2 )
                { Write($" {x} ");
                    return x;
                }
               for ( int y = 2; y < x; y++)
                {
                    if (y == x - 1 && (x % y) != 0)
                    {
                        Write($" {x} ");
                        return x;
                    }
                    else if (x % y == 0)
                    {
                        x = x / PrimeValue(y);
                        PrimeValue(x);
                        break;
                    }
                    else
                        continue;
                }
                return x;
            } 
        }
        static void Main(string[] args)
        {
            
            WriteLine("Enter the number whose multiplier you need to get: ");
            int x = PrimeFactors.PrimeValue(Convert.ToInt32(ReadLine()));
            if( x < 2)
            {
                Write("Prime number cannot be less then 2");
            }
            Write(".");
        }
    }
}
