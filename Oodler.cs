using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oodle
{
    class Oodle
    {
        public static string Oodler(string TextToOodle)
        {
            string OodledText = "";
            foreach(char character in TextToOodle)
            {
                if(character.Equals('A') || character.Equals('E') || 
                    character.Equals('I') || character.Equals('O') ||
                    character.Equals('U') || character.Equals('Y') ||
                    character.Equals('Æ') || character.Equals('Ø') ||
                    character.Equals('Å') || 
                    character.Equals('Ö') || character.Equals('Ä'))
                {
                    OodledText = OodledText + "Oodle";
                }
                else if(character.Equals('a') || character.Equals('e') ||
                    character.Equals('i') || character.Equals('o') ||
                    character.Equals('u') || character.Equals('y') ||
                    character.Equals('æ') || character.Equals('ø') ||
                    character.Equals('å') ||
                    character.Equals('ö') || character.Equals('ä'))
                {
                    OodledText = OodledText + "oodle";
                }
                else
                {
                    OodledText = OodledText + character;
                }
            }

            return OodledText;
        }

        public static string DeOodler(string TextToDeOodle)
        {
            string DeOodledText = "";


            return DeOodledText;
        }
    }
}
