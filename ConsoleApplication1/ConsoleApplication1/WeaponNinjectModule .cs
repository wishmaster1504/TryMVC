using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class WeaponNinjectModule : NinjectModule
    {
        private int weaponNum;

        public WeaponNinjectModule(int weaponNum)
        {
            this.weaponNum = weaponNum;
        }

        public override void Load()
        {
            // weaponNum:
            // 1 - Bazuka
            // 2 - Sword
            // 3 - Knife
            // 4 - Pulemet
            switch (weaponNum)
            {

                case 1:
                    this.Bind<IWeapon>().To<Bazuka>();
                    break;
                case 2:
                    this.Bind<IWeapon>().To<Sword>();
                    break;
                case 3:
                    this.Bind<IWeapon>().To<Knife>();
                    break;
                case 4:
                    this.Bind<IWeapon>().To<Pulemet>();
                    break;
            }
        }

       

    }
}
