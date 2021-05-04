using System;
using System.Collections.Generic;
using System.Text;

namespace LeJeuDuPendu
{
    public class Words
    {

        public String Text { get; set; } // Accessible en lecture et écriture
        public int Lenght { get;  }

        public Words(string text)
        {
            Text = text.ToUpper();
            Lenght = text.Length;

        }

        public int GetIndexOf(char letter)
        {
            return Text.IndexOf(letter);
        }



    }
}
