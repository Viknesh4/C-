using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Piglatin
    {
        public string word;

        public Piglatin()
        {
            this.word = "";
        }

        public void input(string word)
        {
            this.word = word;
        }

        public void display()
        {
            if (this.word.Length == 0)
            {
                Console.WriteLine("Empty word");
                return;
            }
            int vowelIndex = -1;
            string vowels = "aeiouAEIOU";
            foreach (char ch in this.word) 
            {
                if (vowels.IndexOf(ch) >= 0) 
                {
                    vowelIndex = vowels.IndexOf(ch);
                    break;
                }
            }
            if (vowels.Length > 0)
            {
                string piglatin = this.word.Substring(vowelIndex) + this.word.Substring(0, vowelIndex) + "ay";
                Console.WriteLine("Piglatin word is : " + piglatin);
            }
            else
                Console.WriteLine(this.word+"ay");

        }

    }
}
