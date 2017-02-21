namespace DoWithString
{
    /// <summary>
    /// Part where You can delete numbers from String or/and replace these other char.
    /// </summary>
    public partial class DoWithString
    {
        /// <summary>
        /// Author: bluemann
        /// </summary>
        #region Proporities
        string toRemove;
        int countIteration;
        public string output;
        public string str;
        #endregion
        #region Constructor of Class. Argument: string toRemove; chars will delete, not replace;
        public DoWithString(string toRemove)
        {
            this.toRemove = toRemove;
            countIteration = toRemove.Length;
            for (int i = 0; i < countIteration; i++)
            {
                if ((toRemove[i] >= 'a' && toRemove[i] <= 'z') || (toRemove[i] >= 'A' && toRemove[i] <= 'Z'))
                {
                    output += toRemove[i];
                }
                else
                    continue;
            }

        }
        #endregion
        #region Constructor of Class. Argument : string toRemove, chars will replace "toReplace"
        public DoWithString(string toRemove, char toReplace)
        {
            this.toRemove = toRemove;
            countIteration = toRemove.Length;
            for (int i = 0; i < countIteration; i++)
            {
                if ((toRemove[i] >= 'a' && toRemove[i] <= 'z') || (toRemove[i] >= 'A' && toRemove[i] <= 'Z'))
                {
                    output += toRemove[i];
                }
                else
                    output += toReplace;
            }

        }
        #endregion
    }
}
