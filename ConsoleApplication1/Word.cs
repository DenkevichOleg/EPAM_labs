using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Word
    {
        private string wrd = "";
        public string getWord()
        {
            return wrd;
        }
        public void setWord(string newWrd)
        {
            wrd = newWrd;
        }
        public void changeWord(int x, string j)
        {
            if (wrd.Length > x)
            {
                wrd = wrd.Remove(x, 1).Insert(x, j);
            }
        }
    }
}
