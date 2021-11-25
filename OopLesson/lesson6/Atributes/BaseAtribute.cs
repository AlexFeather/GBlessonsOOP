using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6
{
    class BaseAtribute
    {
        public int Value { get; protected set; }
        public AtributeType Type { get; protected set; }
        public List<AtributeBonus> Bonuses { get; protected set; }
        public int BonusTotal 
        {
            get { return BonusTotal; }
            protected set 
            { 
                foreach (AtributeBonus bonus in Bonuses)
                {
                    BonusTotal += bonus.Value;
                }
            }
        }

        public int ValueTotal 
        {
            get { return ValueTotal; }
            protected set
            {
                ValueTotal = Value + BonusTotal;
            }
        }

        public int AtributeModifier
        {
            get { return AtributeModifier; }
            protected set 
            {
                AtributeModifier = (ValueTotal - 10) / 2;
            }
        }

        public BaseAtribute()
        {
            Value = RollValue();
        }

        public BaseAtribute(int value)
        {
            Value = value;
        }

        protected int RollValue()
        {
            Random rnd = new Random();
            return (rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6));
        }
    }
}
