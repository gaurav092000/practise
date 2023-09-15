using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class Reverse_Number
    {
        static void Main()
        {
            int n,sum=0;
            n=int.Parse(Console.ReadLine());    
            while(n>0)
            {
                int r = n % 10;
                sum = (sum * 10) + r;
                n /= 10;    
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
