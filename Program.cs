using System;

namespace csharp
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            RunFizzBuzz();
        }

        public static void RunFizzBuzz() 
        {
            Multiples multiples = new Multiples();
            for(int i = 1; i <= 100; i++) 
            {
                if(multiples.checkMod(i, 3) && multiples.checkMod(i, 5)) 
                {
                    Console.WriteLine("FizzBuzz");
                } else if(multiples.checkMod(i, 3)) {
                    Console.WriteLine("Fizz");
                } else if(multiples.checkMod(i, 5)) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
