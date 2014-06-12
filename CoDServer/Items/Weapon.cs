using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDServer.Items
{
    
    public enum WeaponRange
    {
        CloseContactRange,      // Fist, Kick
        ShortMeleeRange,        // Dagger, Shortsword
        LongMeleeRange,         // Longsword, Bastardsword 
        SpearRange,             // Spear, Greatsword
        PikeRange,              // Pike, Sarissa
        ShortProjectileRange,   // Shuriken, Throwing Dagger
        MediumProjectileRange,  // Shortbow, Crossbow, Handgun
        LongProjectileRange,    // Longbow, Musket, Rifle
        IndirectFireRange       // Cannon, Trebuchet, Magic
    }
    
    public abstract class Weapon : Item
    {
    }
}
