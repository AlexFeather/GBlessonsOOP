using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson6
{
    //contains information for proper interclass interaction
    class WorldBuilder
    {
        public enum AtributeType
        {
            Strength = 0,
            Constitution = 1,
            Dexterity = 2,
            Intellegence = 3,
            Wisdom = 4,
            Charisma = 5
        }

        public enum AtributeBonusType
        {
            Racial = 0,
            Psychic = 1,
            Drug = 2,
            Prothesics = 3
        }

        public enum Race
        {
            Human = 0
        }
        
    }
}
