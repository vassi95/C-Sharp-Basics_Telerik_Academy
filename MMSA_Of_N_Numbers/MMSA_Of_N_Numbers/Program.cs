using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA_Of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("min= {0:F2}", arr.Min());
            Console.WriteLine("max= {0:F2}", arr.Max());
            Console.WriteLine("sum= {0:F2}", arr.Sum());
            Console.WriteLine("avg= {0:F2}", arr.Average());
        }
    }
}
