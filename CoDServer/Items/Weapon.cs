using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDServer.Items
{
    public enum WeaponType
    {
        OneHanded,
        TwoHanded
    }
    
    public abstract class Weapon : Item
    {
    }
}
