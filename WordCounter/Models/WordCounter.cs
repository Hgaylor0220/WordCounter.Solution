using System;

namespace Game.Models
{
    public class WordCount
    {
        public static string WordInput{get; set;}
        public static string SentenceInput {get; set;}
        static int Counter;

        public static bool SetValue(string word,string sentence)
        {
            char [] WordInput = word.ToCharArray();
            char [] SentenceInput = sentence.ToCharArray();
            return true;

        }
        
        public static int RepeatCounter(char word,char sentence)
        {
            Counter =0;
            WordCount.SetValue( WordInput, SentenceInput);
            foreach(char WordInput in SentenceInput)
            if(word == sentence)
            {
                Counter ++;
            }
            return Counter;
        }
    }
}




