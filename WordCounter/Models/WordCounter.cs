using System;

namespace Game.Models
{
    public class WordCount
    {
        public static string wordInput{get; set;}
        public static string sentenceInput {get; set;}
        static int Counter = 0;
        public static bool SetValue(string word,string sentence)
        {
            wordInput = word;
            sentenceInput = sentence;
            return true;

        }
        
        public static int RepeatCounter(string word, string sentenceInput)
        {
            return sentenceInput.Split(wordInput).Length - 1;
        }
    }
}
