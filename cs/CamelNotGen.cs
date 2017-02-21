using System.Collections.Generic;

namespace ProjectPass
{
    public class CamelNotGen
    {
        #region Proporites of class.
        string word;
        int countIteration;
        List<string> wordList;
        string newWord;
        #endregion
        #region Constructor of class.
        /// <summary>
        ///  Ref a word, because we construct object where we have parametr as chars. 
        /// For this object we have a representation in method "AvaibleWords".
        /// </summary>
        /// <param name="word"></param>
        public CamelNotGen(string word)
        {
            this.word = word;
            countIteration = word.Length;
            wordList = new List<string>();
        }
        #endregion
        public List<string> AvaibleWords()
        {
            #region Pierwszy stopień.
            for (int i = 0; i < countIteration; i++)
            {
                string charChanged = (word[i].ToString()).ToUpper();
                newWord = word.Replace(word[i], charChanged[0]);
                wordList.Add(newWord);
            }
#endregion
            #region Drugi stopień.
            for (int j = 0; j < countIteration; j++)
            {
                if (j + 1 < countIteration)
                {
                    string charChanged = (word[j].ToString()).ToUpper();
                    charChanged += (word[j + 1].ToString()).ToUpper();
                    newWord = word.Replace(word[j], charChanged[0]);
                    newWord = newWord.Replace(word[j + 1], charChanged[1]);
                    wordList.Add(newWord);
                }
                else
                { continue; }
            }
#endregion
            #region Trzeci stopień.
            for (int k = 0; k < countIteration; k++)
            {
                if (k + 2 < countIteration)
                {
                    string charChanged = (word[k].ToString()).ToUpper();
                    charChanged += (word[k + 1].ToString()).ToUpper();
                    charChanged += (word[k + 2].ToString()).ToUpper();
                    newWord = word.Replace(word[k], charChanged[0]);
                    newWord = newWord.Replace(word[k + 1], charChanged[1]);
                    newWord = newWord.Replace(word[k + 2], charChanged[2]);
                    wordList.Add(newWord);
                }
                else
                { continue; }
            }
            #endregion
            #region Camel; "WaRsZaWa"
            string camelVerFir = word;
            int m = 0;
            do
            {

                string charChanged = (camelVerFir[m].ToString()).ToUpper();
                camelVerFir =camelVerFir.Replace(camelVerFir[m], charChanged[0]);
                m += 2;

            } while (m < countIteration);
            wordList.Add(camelVerFir);
            #endregion
            #region Camel 2; "WarSzaWa"
            string camelVerSec = word;
            int m = 0;
            do
            {

                string charChanged = (camelVerSec[m].ToString()).ToUpper();
                camelVerFir = camelVerSec.Replace(camelVerSec[m], charChanged[0]);
                m += 3;

            } while (m < countIteration);
            wordList.Add(camelVerSec);
            #endregion
            return wordList;
        }
    }
}