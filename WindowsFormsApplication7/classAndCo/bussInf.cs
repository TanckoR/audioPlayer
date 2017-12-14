using System;
using Un4seen.Bass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    public static class bussInf
    {

        public static int hz = 44100;//частота дискретизации
        public static bool initDefDevise;//состояние инициализации
        public static int Stream;//канал
        public static int Volume = 100;//громкость
        private static bool isStoped = true;//канал остановлен вручную
        public static bool EndPlayList;//проигран весь треклист


        public static bool InitBass(int hz)//инициализация bass.dll
        {
            if (!initDefDevise)            
                initDefDevise = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);                
            return initDefDevise;
        }


        public static void Pause() {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
            }
        }
        
        public static void Play(string fileName,int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(hz))
                {
                    Stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream,false);
                    }
                }
            }
            else Bass.BASS_ChannelPlay(Stream,false);
            isStoped = false;
        }

        public static int getTimeOfStream(int stream)//получение длительности в секундах
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        public static int getPosOfStream(int stream)//получение текущей позиции
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public static void setPosOfScroll(int stream,int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
        }

        public static void SetVolume(int stream,int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
            
        }

        public static bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (Main.Files.Count > Main.CurrentTrackNumber + 1)
                {
                    Play(Main.Files[++Main.CurrentTrackNumber],Volume);
                    EndPlayList = false;
                    return true;
                }
                EndPlayList = true;
            }
            return false;
        }
    }
}
