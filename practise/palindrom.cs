using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class palindrom
    {
        static void Main()
        {
            int n,r,sum=0;
            n=int.Parse(Console.ReadLine());
            int m = n;
            while(n>0)
            {
                 r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(sum==m)
            {
                Console.WriteLine("Palindrom");

            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
            Console.ReadLine();
        }
    }
}
