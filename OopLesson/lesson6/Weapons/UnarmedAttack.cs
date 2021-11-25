using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson6.Weapons
{
    class UnarmedAttack : BaseWeapon
    {
        public UnarmedAttack()
        {
            WeaponDice = 4;
            WeaponModifier = 0;
        }
    }
}
