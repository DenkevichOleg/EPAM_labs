using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Text
    {
        public List<Sentence> Ls = new List<Sentence>();
        private string krujka = "";
        public string getText()
        {
            string Tx = "";
            for (int i = 0; i < Ls.Count; i++)
            {
                Tx += Ls[i].getSentence() + krujka[i];
            }
            return Tx;
        }
        public void setText(string Tx)
        {
            for (int i = 0; i < Tx.Length; i++)
            {
                if(Tx[i]=='.'||Tx[i]=='?'||Tx[i]=='!')
                {
                    krujka += Tx[i];
                }
            }
            krujka+=' ';

            string[] mas = Tx.Split(new char[] { '.', '?', '!' }, System.StringSplitOptions.None);
             for (int i = 0; i < mas.Length; i++)
             {
                 Ls.Add(new Sentence());
                 Ls[i].setSentence(mas[i]);
             }
        }
        public void changeText(int oldS, string newS) 
        {
            for (int i = 0; i < Ls.Count; i++)            
            {
                for (int j = 0; j < Ls[i].Lw.Count; j++)
                {
                    Ls[i].Lw[j].changeWord(oldS, newS);
                }
            }
        }

    }
}
