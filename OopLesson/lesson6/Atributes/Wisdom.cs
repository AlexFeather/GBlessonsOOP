using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6.Atributes
{
    class Wisdom : BaseAtribute
    {
        public Wisdom()
        {
            Value = RollValue();
            Type = AtributeType.Wisdom;
        }
    }
}
