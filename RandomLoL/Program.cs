using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLoL
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(RastgeleGülüş.RastgeleGül(40));
            }
            Console.ReadKey();
        }
    }
}
