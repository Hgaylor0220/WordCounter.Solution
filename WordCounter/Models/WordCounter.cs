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
        
        public int WordCount()
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


    }
}
