using System;

namespace Game.Models
{
    public class WordCount
    {
        public static string Input{get; set;}
        static int Counter = 0;

        public static bool RepeatCounter(string input)
        {
            Input = input;
            return true;
        }
    }
}




