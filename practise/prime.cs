using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{


    internal class prime
    {
        static void Main()
        {
            int n,count =0;
            Console.WriteLine("Enter the Number");
            n=int.Parse(Console.ReadLine());    
            for(int i=1;i<=n;i++)
            {
                if(i%n==0)
                {
                    count++;
                }
            }
            if(count ==2)
            {
                Console.WriteLine("It is a prime number");

            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
            Console.ReadLine(); 

        }
    }
}
