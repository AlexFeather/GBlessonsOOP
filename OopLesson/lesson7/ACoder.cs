using System;
using System.Collections.Generic;
using System.Text;

namespace OopLesson.lesson7
{
    public class ACoder : ICoder
    {

        public string Decode(string encoded)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char element in encoded)
            {
                sb.Append((char)(element - 1));
            }
            return sb.ToString();
        }

        public string Encode(string initial)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char element in initial)
            {
                sb.Append((char)(element + 1));
            }
            return sb.ToString();
        }
    }
}
