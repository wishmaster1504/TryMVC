using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Knife : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Say hello to vy knife");
        }
    }
}
