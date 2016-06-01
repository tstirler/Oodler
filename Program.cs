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
            string TextToOodle = "Jouluyö, juhlayö!\r\nPäättynyt kaik on työ.\r\nKaks vain valveil on puolisoa\r\nlapsen herttaisen nukkuessa\r\nseimikätkyessään,\r\nseimikätkyessään.";
            string OodledText = Oodle.Oodler(TextToOodle);
            Console.WriteLine("{0}\r\n\r\n{1}", TextToOodle, OodledText);
            Console.Read();
        }
    }
}
