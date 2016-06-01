using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oodle
{
    class Oodle
    {
        public static string[] Oodler(string TextToOodle, string OodleWord)
        {
            string[] returnString = new string[2];
            string _oodleWord = OodleWord;
            string _oodledString = "";
            string _removedVowels = "";
            foreach(char character in TextToOodle)
            {
                if(character.Equals('A') || character.Equals('E') || 
                    character.Equals('I') || character.Equals('O') ||
                    character.Equals('U') || character.Equals('Y') ||
                    character.Equals('Æ') || character.Equals('Ø') ||
                    character.Equals('Å') || 
                    character.Equals('Ö') || character.Equals('Ä') ||
                    character.Equals('Ú') || character.Equals('Í') ||
                    character.Equals('Ó'))
                {
                    _oodledString = _oodledString + _oodleWord;
                    _removedVowels = _removedVowels + character;
                }
                else if(character.Equals('a') || character.Equals('e') ||
                    character.Equals('i') || character.Equals('o') ||
                    character.Equals('u') || character.Equals('y') ||
                    character.Equals('æ') || character.Equals('ø') ||
                    character.Equals('å') ||
                    character.Equals('ö') || character.Equals('ä') ||
                    character.Equals('ú') || character.Equals('í') ||
                    character.Equals('ó'))
                {
                    _oodledString = _oodledString + _oodleWord.ToLower();
                    _removedVowels = _removedVowels + character;
                }
                else
                {
                    _oodledString = _oodledString + character;
                }
            }
            returnString[0] = _oodledString;
            returnString[1] = _removedVowels;
            return returnString;
        }

        public static string DeOodler(string[] TextToDeOodle, string OodleWord)
        {
            string textToDeOodle = TextToDeOodle[0];
            string removedVowels = TextToDeOodle[1];
            int TextToDeOodleLength = textToDeOodle.Length -1;
            int CurrentVowel = removedVowels.Length - 1;
            int OodleLength = OodleWord.Length;
            string lastWord = "";
            string DeOodledText = "";

            for (int i = TextToDeOodleLength; i >= 0; i--)
            {
                lastWord = CharInsert(lastWord, textToDeOodle[i]);
                if(lastWord.ToLower().Equals(OodleWord.ToLower()))
                {
                    DeOodledText = DeOodledText + removedVowels[CurrentVowel];
                    CurrentVowel--;
                    lastWord = "";
                }
                else if(lastWord.Length == OodleWord.Length || i < OodleLength)
                {
                    DeOodledText = DeOodledText + lastWord[lastWord.Length - 1];
                    lastWord = RemoveLastCharacter(lastWord);
                }
            }

            DeOodledText = ReverseString(DeOodledText);

            return DeOodledText;
        }

        public static string RemoveLastCharacter(string StringToRemoveFrom)
        {
            string ReturnString = "";
            int StringLength = StringToRemoveFrom.Length - 1;
            for (int i = 0; i < StringLength; i++)
            {
                ReturnString = ReturnString + StringToRemoveFrom[i];
            }
            return ReturnString;
        }

        public static string CharInsert(string CurrentString, char characterToInsert)
        {
            string returnString = Convert.ToString(characterToInsert);
            returnString = returnString + CurrentString;
            return returnString;
        }

        public static string ReverseString(string StringToReverse)
        {
            string ReturnString = "";
            for (int i = StringToReverse.Length - 1; i >= 0; i--)
            {
                ReturnString = ReturnString + StringToReverse[i];
            }
            return ReturnString;
        }
    }
}
