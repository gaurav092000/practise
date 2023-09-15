using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    internal class PrimeByWhile
    {

        static void Main()
        {
            int a = 1, i, count;
            while (a<=100)
            {
                i = 2;
                count = 0;
                while (i <= a / 2)
                {
                    if(a%i==0)
                    {
                        count++;
                        break;
                    }
                    i++;
                }
                if(count==0 && a!=1)
                {
                    Console.WriteLine(a);
                }

                a++;
            }
            Console.ReadLine(); 
         }
        
        
    }
}
