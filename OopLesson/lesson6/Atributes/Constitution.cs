using System;
using System.Collections.Generic;
using System.Text;
using static OopLesson.lesson6.WorldBuilder;

namespace OopLesson.lesson6.Atributes
{
    class Constitution : BaseAtribute
    {
        public Constitution()
        {
            Value = RollValue();
            Type = AtributeType.Constitution;
        }

    }
}
