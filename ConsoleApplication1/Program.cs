using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Object obj = a;
            int c = (int)obj;
            Console.WriteLine(c);
        }
    }
}
