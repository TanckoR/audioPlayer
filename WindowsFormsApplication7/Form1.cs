using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public tagModel TM;
        playList playlist1 = new playList();
        public int songIndex=0;
        public Form1()
        {
            InitializeComponent();
            Main.link = this;
            bussInf.InitBass(bussInf.hz);
            Main.SetInputFormats();
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            playlist.Visible = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string [] tmp = openFileDialog1.FileNames;
            for(int i = 0; i < tmp.Length; i++)
            {
                Main.Files.Add(tmp[i]);
                TM = new tagModel(tmp[i]);
                playlist.Items.Add(i+1+". "+TM.artist + " - " + TM.title/* + "-" + TM.album*/);
                
            }
        }

        void startPlaySong(int index)
        {
            if (playlist.Items.Count != 0)
            {  
                string current = Main.Files[index];
                string[] tmp = current.Split('\\');
                if (playlist.SelectedIndex == -1) { Main.CurrentTrackNumber = 0; }
                Main.CurrentTrackNumber = playlist.SelectedIndex;
                
                bussInf.Play(current, bussInf.Volume);
                label1.Text = TimeSpan.FromSeconds(bussInf.getPosOfStream(bussInf.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(bussInf.getTimeOfStream(bussInf.Stream)).ToString();
                progressMusicBar.Maximum = bussInf.getTimeOfStream(bussInf.Stream);
                progressMusicBar.Value = bussInf.getPosOfStream(bussInf.Stream);
                timer1.Enabled = true;

                label3.Text =playlist.SelectedIndex+1+". "+ tmp[tmp.Length - 1];               
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex == -1) {
                playlist.SelectedIndex = 0;
                startPlaySong(playlist.SelectedIndex);
            }
            else
            {
                startPlaySong(playlist.SelectedIndex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(bussInf.getPosOfStream(bussInf.Stream)).ToString();
            progressMusicBar.Value = bussInf.getPosOfStream(bussInf.Stream);

            if (bussInf.ToNextTrack())
            {
                playlist.SelectedIndex = Main.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(bussInf.getPosOfStream(bussInf.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(bussInf.getTimeOfStream(bussInf.Stream)).ToString();
                progressMusicBar.Maximum = bussInf.getTimeOfStream(bussInf.Stream);
                progressMusicBar.Value = bussInf.getPosOfStream(bussInf.Stream);
            }

            if (bussInf.EndPlayList)
            {
                stopButton_Click(this, new EventArgs());
                playlist.SelectedIndex = Main.CurrentTrackNumber = 0;
                bussInf.EndPlayList = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            bussInf.Stop();
            timer1.Enabled = false;
            progressMusicBar.Value = 0;
            label1.Text = "00:00:00";
        }

        private void progressMusicBar_Scroll(object sender, ScrollEventArgs e)
        {
            bussInf.setPosOfScroll(bussInf.Stream, progressMusicBar.Value);
        }

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            bussInf.SetVolume(bussInf.Stream, volumeBar.Value);
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            bussInf.Pause();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            try
            {
                startPlaySong(--playlist.SelectedIndex);
            }
            catch { }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                startPlaySong(++playlist.SelectedIndex);
            }
            catch { }    
        }

        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // new playList().Show();
            if (playlist.Visible)
            {
                playlist.Visible = true;
            }
            else { playlist.Visible = false; }
            //label3.Text = "" + playlist.Items.Count;
        }
    }
}
