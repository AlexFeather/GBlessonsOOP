using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson
{
    class StringsWork
    {

        public string StringReverse(string input)
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i<input.Length; i++)
            {
                builder.Insert(0, input[i]);
            }
            return builder.ToString();
        }

    }
}
