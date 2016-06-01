using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oodle
{
    class Program
    {
        static void Main(string[] args)
        {
            string TextToOodle = "Ja, vi elsker dette landet\r\nsom det stiger frem\r\nfuret, værbitt over vannet,\r\nmed de tusen hjem.\r\nElsker, elsker det og tenker\r\npå vår far og mor,\r\nog den saganatt som senker\r\ndrømmer på vår jord.";
            string OodleWord = "Oodle";
            string[] OodledText;
            string DeOodledText;
            OodledText = Oodle.Oodler(TextToOodle, OodleWord);
            DeOodledText = Oodle.DeOodler(OodledText, OodleWord);


            Console.WriteLine("Text: {0}\r\n\r\nOodled:\r\n{1}\r\nRemoved vowels:\r\n{2}", TextToOodle, OodledText[0], OodledText[1]);
            Console.WriteLine("DeOodled:\r\n{0}", DeOodledText);
            Console.Read();
        }
    }
}
