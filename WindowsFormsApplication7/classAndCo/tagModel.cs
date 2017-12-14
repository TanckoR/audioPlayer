using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;


namespace WindowsFormsApplication7
{
    public class tagModel
    {
        public int BitRate;
        public int freq;
        public string channels;
        public string artist;
        public string album;
        public string title;
        public string year;

        Dictionary<int, string> chanelDict = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo" }
        };
        public tagModel(string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);
            BitRate = tagInfo.bitrate;
            freq = tagInfo.channelinfo.freq;
            channels = chanelDict[tagInfo.channelinfo.chans];
            artist = tagInfo.artist;
            album = tagInfo.album;
            if(tagInfo.title == "") { title = Main.GetFileName(file); }
            else { title = tagInfo.title; }
            year = tagInfo.year;
        }
    }
}
