using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeerProblemStatementSolution
{
    class FactorialRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give any number between 1 to 100000");
            int val =  Convert.ToInt32(Console.ReadLine());
            int result = FactorialRemainderResult(val);
            Console.WriteLine("Cumulative count is {0}", result);
            Console.ReadLine();
        }
        
        private static int FactorialRemainderResult(int val)
        {
            int count = 0;

            for(int i = 1; i<=val; i++)
            {
                int mod = (i - 1) % i;
                if (FactorialRemainder.Factorial(mod) % i == i - 1)
                    count++;
            }

            return  count;
        }
        public static int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }
    }
}
