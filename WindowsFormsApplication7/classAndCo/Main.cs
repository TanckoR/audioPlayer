using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
     public  class Main
    {
        public static Form1 link;
        public static playList PlayList;
        
        public static List<string> Files = new List<string>();//список полных имен файлов

        public static int CurrentTrackNumber;//текущая номер трека

        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }

        public static void SetInputFormats()
        {
            link.openFileDialog1.Filter = "Все форматы| *.mp3"+"|MPEG Audio Layer III (*.mp3)|*.mp3";
        }
    }
}
