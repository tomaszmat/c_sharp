using System.Collections.Generic;

namespace StringAddString
{
    public class StringAddString
    {
        #region Proporites of class.
        int date;
        int shortCutDate;
        List<string> words;
        List<string> newWordsList;
        List<string> personalWords;
        string[] arrayWords;
        string[] arrayPersonalWords;
        string[] arrayExecuteOfWords;
        #endregion

        #region Constructor of class. Arguments : List<string> words, int date
        public StringAddString(List<string> words, int date)
        {
            this.words = words;
            this.date = date;
            newWordsList = new List<string>();
            if (date > 2000)
            {
                shortCutDate = date - 1900;

            }

            else if (date < 2000 && date > 1000)
            {
                string tempToOperate = (date.ToString()).Remove(0, 2);
                shortCutDate = int.Parse(tempToOperate);
            }
            else
                shortCutDate = 0;

            for (int i = 0; i < words.Count; i++)
            {
                newWordsList.Add(words[i] + date.ToString());
            }

            for (int i = 0; i < words.Count; i++)
            {
                newWordsList.Add(words[i] + shortCutDate.ToString());
            }

        }
        #endregion

        #region Constructor of class. Arguments : List<string> words, List<string> personalWords
        public StringAddString(List<string> words, List<string> personalWords)
        {
            this.words = words;
            this.personalWords = personalWords;
            newWordsList = new List<string>();
            for(int i = 0; i <words.Count; i++)
            {
                for (int j = 0; i < personalWords.Count; j++)
                {
                    newWordsList.Add(words[i] + personalWords[j]);
                }
            }
        }
        #endregion

        #region Constructor of class. Arguments : string[] arrayWords, string[] arrayPersonalWords
        public StringAddString(string[] arrayWords, string[] arrayPersonalWords)
        {
            this.arrayWords = arrayWords;
            this.arrayPersonalWords = arrayPersonalWords;
            int sizeOfNewArray = (arrayWords.Length) * (arrayPersonalWords);
            arrayExecuteOfWords = new string[sizeOfNewArray];
            for (int i = 0; i < arrayWords.Length; i++)
            {
                for (int j = 0; i < arrayPersonalWords.Length; j++)
                {
                   (arrayWords[i] + arrayPersonalWords[j]);
                }
            }
        }
        #endregion

    }
}
