using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaBits
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string characters = "";
            bool getInput = true;

            while(getInput)
            { 
                ConsoleKeyInfo cki = Console.ReadKey(true);
                char c = cki.KeyChar;

                if (c == '=')  // is this the secret easter egg character?
                {
                    Console.Clear();
                    Functions.display(characters);
                    s = String.Format("Boo yah!! Secret Easter egg character!");
                    Functions.display(s);
                    continue;
                }

                // is this a character a-z ?
                if (c < 'a' || c > 'z')
                {
                    s = String.Format("Error: '{0}' isn't a lower-case letter!",c);
                    Functions.display(s);
                    continue;
                }

                // has this letter already been entered?
                if (characters.IndexOf(c) > -1)
                {
                    s = String.Format("Error: this letter has already been entered");
                    Functions.display(s);
                    continue;
                }

                characters = Functions.addChar(characters, c);  // add inputted character to main string

                // do display routine
                Console.Clear();
                //Console.WriteLine(characters);
                int charactersCorrect = Functions.countCharacters(characters);
                string letterz = charactersCorrect == 1 ? " letter" : " letters";
                s = String.Format(charactersCorrect + letterz + " correct");
                Functions.display(s);
                if (charactersCorrect == 13)
                {
                    s = String.Format("Oooh! Halfway there! Keep going!!");
                    Functions.display(s);
                }
                if (charactersCorrect == 26)
                {
                    s = String.Format("You are a master of the alphabet.\n");
                    Functions.display(s);
                    getInput = false;
                }
            }

        }
    }
}
