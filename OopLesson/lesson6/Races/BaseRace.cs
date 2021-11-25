using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson6
{
    class BaseRace
    {
        public string Name { get; protected set; }
        public string Descriprion { get; protected set; }
        public List<AtributeBonus> BonusList { get; protected set; }
    }
}
