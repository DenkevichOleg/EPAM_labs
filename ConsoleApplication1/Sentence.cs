using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sentence
    {
        public List<Word> Lw = new List<Word>();
        public string getSentence()
        {
            string sent = "";
            for (int i = 0; i < Lw.Count; i++)
            {
                sent += Lw[i].getWord();
                if(i < Lw.Count - 1)
                {
                    sent += ' ';
                }
            }
            return sent;
        }
        public void setSentence(string sent)
        {
                string[] mas = sent.Split(' ');
                for (int j = 0; j < mas.Length; j++)
                {
                    Lw.Add(new Word());
                    Lw[j].setWord(mas[j]);
                }
            }
        }
    }

