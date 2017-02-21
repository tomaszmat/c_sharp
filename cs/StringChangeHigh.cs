namespace DoWithString
{
/// <summary>
/// Part where You can change string high.
/// </summary>
    public partial class DoWithString
    {
        /// <summary>
        /// Author: bluemann
        /// </summary>
        #region Proporities
        string outStringLast;
        string outStringFirst;
        #endregion
        #region Constructor of class. Without par.
        public DoWithString(){ }
        #endregion
        #region "xxx" -> "XXX"
        public string FirstUp(string str)
        {
            this.str = str;
            char a = str[0];
            if (str[0] >= 'a' && str[0] <= 'z')
            {
                a = (char)(str[0] - 32);
                outStringFirst = a.ToString();
                for (int i = 1; i < str.Length; i++)
                { outStringFirst += str[i]; }
            }
            else
                outStringFirst = str;
            return outStringFirst;
        }
#endregion
        #region "xxx" -> "xxX"
        public string LastUp(string str)
        {
            this.str = str;
            char a = str[str.Length - 1];
            if (str[str.Length - 1] >= 'a' && str[str.Length - 1] <= 'z')
            {
                a = (char)(str[str.Length - 1] - 32);
                for (int i = 0; i < str.Length - 1; i++)
                { outStringLast += str[i]; }
                outStringLast += a.ToString();
            }
            else
                outStringLast = str;
            return outStringLast;
        }
#endregion
        #region "XXX" -> "xXX"
        public string FirstDown(string str)
        {

            this.str = str;
            char a = str[0];
            if (str[0] >= 'A' && str[0] <= 'Z')
            {
                a = (char)(str[0] + 32);
                outStringFirst = a.ToString();
                for (int i = 1; i < str.Length; i++)
                { outStringFirst += str[i]; }
            }
            else
                outStringFirst = str;
            return outStringFirst;

        }
#endregion
        #region "XXX" -> "XXx"
        public string LastDown(string str)
        {

            this.str = str;
            char a = str[str.Length - 1];
            if (str[str.Length - 1] >= 'A' && str[str.Length - 1] <= 'Z')
            {
                a = (char)(str[str.Length - 1] + 32);
                for (int i = 0; i < str.Length - 1; i++)
                { outStringLast += str[i]; }
                outStringLast += a.ToString();
            }
            else
                outStringLast = str;
            return outStringLast;

        }
        #endregion
    }
}
