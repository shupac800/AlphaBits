using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaBits
{
    public class Functions
    {
        public static string addChar(string characters, char c)
        {
            characters += c;
            return characters;
        }
        public static int countCharacters(string characters)
        {
            return characters.Length;
        }
        public static void display(string s)
        {
            Console.WriteLine(s);
        }
    }
}
