using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

        public void FileEmailSeparator(string inputPath, string outputPath)
        {
            string[] stringArray = File.ReadAllLines(inputPath);
            for (int i = 0; i < stringArray.Length; i++)
            {
                EmailSeparator(ref stringArray[i]);
            }
            File.WriteAllLines(outputPath, stringArray);
        }

        private void EmailSeparator(ref string input)
        {
            input = input.Split('&')[1];
        }



    }
}
