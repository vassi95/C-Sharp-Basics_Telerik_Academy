using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int[] speeds = new int[c];
            int countOfGroups = 1;
            for(int i = 0; i < c; i++)
            {
                speeds[i] = int.Parse(Console.ReadLine());
            }
           // Array.Reverse(speeds);
            for(int j=1; j < speeds.Length; j++)
            {
                if (speeds[j] == speeds[j-1])
                {
                    countOfGroups++;

                }
                else if(speeds[j] > speeds[j-1])
                {
                    speeds[j] = speeds[j-1];
                    
                }
                else
                {
                    countOfGroups++;
                }
            }
            Console.WriteLine(countOfGroups);
        }
    }
}
