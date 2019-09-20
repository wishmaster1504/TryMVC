using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    public class Pulemet : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("TRATATATATATATATATA");
            Console.Clear();
            for (var i = 0; i < 15; i++)
            {
                Console.Write("-");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("TRATATATATATATATATA");
        }
    }
}
