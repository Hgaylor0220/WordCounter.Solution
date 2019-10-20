namespace Counter.Models
{
    
    public class RepeatCounter
    {
        public string UserWord{get; set;}
        public string Sentence {get; set;}


        public RepeatCounter(string word, string sentence)
        {
            UserWord = word;
            Sentence = sentence;
        }
        
        public int CountWord()
        {
            int Count=0;
            UserWord.ToLower();
           
    
            foreach(var word in Sentence)
            {
                if(word == word)
                {
                Count ++;
                
                }
            }
                return Count;
        }

        static string TrimPunctuation(string Sentence)
        {
            int removeStartPunct =0;
            for (int i=0; i < Sentence.Length; i++)
            {
                if (char.IsPunctuation(Sentence[i]))
                {
                    removeStartPunct ++;
                }
                
            }
            int removeEndPunct = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (char.IsPunctuation(Sentence[i]))
                {
                    removeEndPunct++;
                }

            }
            if (removeStartPunct == Sentence.Length &&
            removeEndPunct == Sentence.Length)
            {
                return " ";
            }
            return Sentence.Substring(removeStartPunct,
            Sentence.Length - removeEndPunct - removeStartPunct);
        }
        


    }
}
