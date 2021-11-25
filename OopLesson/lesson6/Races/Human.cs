using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6.Races
{
    class Human : BaseRace
    {
        public Human()
        {
            Race = Race.Human;
            Name = "Human";
            Descriprion = "A baseline human";
            BonusList = new List<AtributeBonus>();
            BonusList.Add(new AtributeBonus(2, AtributeBonusType.Racial, AtributeType.Charisma));
        }
    }
}
