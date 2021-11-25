using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson7
{
    interface ICoder
    {
        public string Encode(string initial);
        public string Decode(string encoded);
    }
}
