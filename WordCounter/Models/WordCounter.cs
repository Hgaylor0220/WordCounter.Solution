using System;

namespace Game.Models
{
    public class WordCount
    {
        public static string WordInput{get; set;}
        public static string SentenceInput {get; set;}
        static int Counter = 0;

        public void SetValue(string word, string sentence)
        {
            WordInput = word;
            SentenceInput = sentence;
            
        }
        
        public static int RepeatCounter(string word,string sentence)
        {
            Counter = 0;
            if(word == sentence)
            {
                Counter ++;
            }
            return Counter;
        }
    }
}




