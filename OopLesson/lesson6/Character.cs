using OopLesson.lesson6.Atributes;
using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;


namespace OopLesson.lesson6
{
    class Character
    {
        private Random rnd = new Random();
        public Strength Str;
        public Constitution Con;
        public Dexterity Dex;
        public Intellegence Int;
        public Wisdom Wis;
        public Charisma Cha;
        public Race Race;
        public readonly int BaseAC = 10;
        public int HP 
        { get { return HP; }
            set { HP = 8 + Con.AtributeModifier; }
        } 

        public Character(Race race)
        {
            Race = race;
        }

        public void ActionStrike(Character target, BaseWeapon weapon)
        {
            if (rnd.Next(1, 20) + Str.AtributeModifier + weapon.WeaponModifier > target.BaseAC)
            {
                target.SufferDamage(weapon.WeaponDice + weapon.WeaponModifier + Str.AtributeModifier);
            }
        }

        public void SufferDamage(int dmg)
        {
            HP = HP - dmg;
        }
    }
}
