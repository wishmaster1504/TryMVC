using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static IKernel AppKernel;
        public static IKernel AppKernel2;

        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new WeaponNinjectModule(3));

            var warrior = AppKernel.Get<Warrior>(); 
            warrior.Kill();

            var otherWarrior = new OtherWarrior();
            otherWarrior.Kill();

            var anotherWarrior = AppKernel.Get<AnotherWarrior>();
            anotherWarrior.Kill();

            // сменим воину оружие
            AppKernel2 = new StandardKernel(new WeaponNinjectModule(4));
            warrior = AppKernel2.Get<Warrior>();
            warrior.Kill();

            otherWarrior = new OtherWarrior();
            otherWarrior.Kill();

            Console.ReadKey();

          
        }
    }
}
