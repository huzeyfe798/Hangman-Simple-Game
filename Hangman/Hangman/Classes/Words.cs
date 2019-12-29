using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Classes
{
    class Words
    {
        string[] _words = { 
        "elma",
        "araba",
        "kitap",
        "aslan",
        "program"
        
        };


        int length = 5;

        public string[] words { get => _words; set => _words = value; }
        public int Length { get => length; set => length = value; }
    }
}
