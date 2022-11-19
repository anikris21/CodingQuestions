namespace CodingQuestions
{
    class Wordsearch
    {

        public static bool wordsearchhelper(char[,] words, string word)
        {
            for(int i=0; i<words.Rank; i++)
            {
                for(int j=0; j<words.GetLength(i); j++)
                {
                    if(getwordsearch(words, i, j, word))
                    {
                        return true;
                    }
                    // return getwordsearch(words, i, j, word); 
                }
            }

            return false;
        }
        public static bool getwordsearch(char[,] words, int i, int j, string word)
        {

            Console.WriteLine( word);
            Console.WriteLine("i = " + i.ToString() + " j = " + j.ToString());

            if(word.Length == 0) return true;

            if((i< 0 || j< 0) || (i>= words.GetLength(0 ) || j >= words.GetLength(0)))             
            {
                return false;
            }

            if (words[i, j] == word[0])
                return getwordsearch(words, i, j-1, word.Substring(1))
                    || getwordsearch(words, i, j + 1, word.Substring(1))
                    || getwordsearch(words, i + 1, j, word.Substring(1))
                    || getwordsearch(words, i - 1, j, word.Substring(1));

            return false;
            
        }



    }
}