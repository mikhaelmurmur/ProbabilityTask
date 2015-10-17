using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int betta = 2;
            double probability = 0.0;
            while (probability < 0.5)
            {
                probability = (Math.Pow(6, betta - 1) - Math.Pow(5, betta - 1)) /
                              (6 * (Math.Pow(6, betta) - 35 * (Math.Pow(6, betta - 2) - Math.Pow(5, betta - 2))));
                betta++;
            }
            Console.WriteLine(betta - 1);
        }
    }
}
