using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6
{
    class AtributeBonus
    {
        public int Value { get; private set; }
        public AtributeBonusType Type { get; private set; }
        public AtributeType Atribute { get; private set; }

        public AtributeBonus(int value, AtributeBonusType type, AtributeType atribute)
        {
            Value = value;
            Type = type;
            Atribute = atribute;
        }
    }
}
