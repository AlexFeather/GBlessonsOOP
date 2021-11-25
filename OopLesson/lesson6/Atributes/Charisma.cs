using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6.Atributes
{
    class Charisma : BaseAtribute
    {
        public Charisma()
        {
            Value = RollValue();
            Type = AtributeType.Charisma;
        }
    }
}
