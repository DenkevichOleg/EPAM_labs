using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводи строку");
            string s = Console.ReadLine();
            if (s == "") s = "съешь., еще этих, мягких францзких.. булок?да...выпей! чаю .. ...  . . .....";
            ConsoleApplication1.Text r = new Text();
            r.setText(s);
            Console.WriteLine("Ты ввел эту строку: ");
            Console.WriteLine(r.getText());
            Console.WriteLine("Води номер символа который хочешь заменить в этой строке");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Води символ на который будет производится замена");
            string j = Console.ReadLine();
            r.changeText(i, j);
            Console.WriteLine("Вот что получилось: ");
            Console.WriteLine(r.getText());
           /* Console.WriteLine("По предложениям: ");
            for (int g = 0; g < r.Ls.Count; g++)
            {
                Console.WriteLine(r.Ls[g].getSentence());
            }
            Console.WriteLine("По словам: ");
            for (int g = 0; i < r.Ls.Count; g++)
            {
                for (int v = 0; v < r.Ls[g].Lw.Count; v++)
                {
                    Console.WriteLine(r.Ls[g].Lw[v].getWord());
                }
            }*/

        }
    }
}
