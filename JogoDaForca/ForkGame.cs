using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class ForkGame
    {
        private string stringJogo = "";
        private string stringReal;
        private List<string> jogoList;
        private Random rand;
        private int lifes;

        public ForkGame()
        {
            jogoList = new List<string> { "dagoberto", "neymar", "ganso" };
            rand = new Random();
            this.stringReal = jogoList[rand.Next(jogoList.Count)];
            for(int i = 0; i < stringReal.Length; i++)
            {
                this.stringJogo += "_";
            }
            this.lifes = 10;
        }

        public string StringJogo() {
            return this.stringJogo;
        }

        public string StringReal()
        {
            return this.stringReal;
        }

        public string RunArray(char a, string s, string real)
        {
            string newString = "";
            for(int i = 0; i<s.Length; i++)
            {
                if (real[i] == a)
                {
                    newString += a;
                
                }
                else if (s[i] != '_')
                {
                    newString += s[i];
                }
                else
                {
                    newString += "_";
                }
            }
            return newString;
        }

        public bool checkIfWin(string s, string real) {
            if(s == real)
            {
                return true;
            }
            return false;
        }
    }
}
