using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Classes
{
    class Game
    {
        string word;

        bool contr;

        int guessCount = 0;
        int trueGuessCount;

        public string Word { get => word; set => word = value; }
        public int Guesscount { get => guessCount; set => guessCount = value; }
        public int Trueguesscount { get => trueGuessCount; set => trueGuessCount = value; }
        public bool Contr { get => contr; set => contr = value; }

        public void KeyControl (char key)
        {
            string word1 = Word;
            
            for (int i = 0; i < word1.Length; i++)
            {
                
                
                if(word1[i] == key)
                {
                    Contr = true;
                    break;
                }
                else
                {
                    Contr = false;
                }
            }

            if (Contr)
                Trueguesscount = Trueguesscount + 1;
            else if (!Contr)
                Guesscount = Guesscount + 1;
        }

        
    }
}
