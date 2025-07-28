using Songify.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songify
{

    public partial class MusicOpener : Form
    {

        WMPLib.WindowsMediaPlayer wplayer;
        public int counter = 0;
        public int counterForPlaylist = 0;
        public string playlistname = string.Empty;
        public bool startOrStop = false;
        public static MusicOpener instance;
        public Label[] MusicLabelCounter = new Label[1];
        public string[] FileNamesOfMusic = new string[1];
        public Label[] PlaylistLabelCounter = new Label[1];
        public Panel p6;
        public Panel p3;
        public bool alternator = false;
        public string currentmusic;
        public int numerOfCurrentMusic;
        public Random rand = new Random();
        public MusicOpener()
        {
            InitializeComponent();
            instance = this;
            p3 = panel3;
            p6 = panel6;
            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "";
            wplayer.controls.pause();
            
        }
        private void MusicOpener_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("PlaylistDirectory");
            foreach (string file in files)
            {
                PlaylistInList playlistToTest = new PlaylistInList(file);
                playlistname = file;
                playlistToTest.AddList();

                counterForPlaylist++;
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Settings
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings settingsHere = new Settings();
            settingsHere.ShowDialog();
        }
        //Start

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(startOrStop == false) { 
                wplayer.URL = FileNamesOfMusic[numerOfCurrentMusic];
                wplayer.controls.play();
                if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {

                    wplayer.controls.play();

                }
                pictureBox2.Image = Image.FromFile("Img\\image9.png");
                startOrStop = true;
            }
            else if(startOrStop == true)
            {
                wplayer.URL = FileNamesOfMusic[numerOfCurrentMusic];
                wplayer.controls.stop();
                if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {

                    wplayer.controls.stop();

                }
                pictureBox2.Image = Image.FromFile("Img\\image3.png");
                startOrStop = false;
            }



        }

        //Backward
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try 
            { 
                numerOfCurrentMusic--;
                wplayer.URL = FileNamesOfMusic[numerOfCurrentMusic];
                MusicLabelCounter[numerOfCurrentMusic].ForeColor = Color.PowderBlue; 
                MusicLabelCounter[numerOfCurrentMusic].BackColor = Color.FromArgb(51, 83, 188);
                MusicLabelCounter[numerOfCurrentMusic+1].ForeColor = Color.FromArgb(51, 83, 188);
                MusicLabelCounter[numerOfCurrentMusic+1].BackColor = Color.PowderBlue;
                wplayer.controls.play();
                if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {

                    wplayer.controls.play();

                }
            }
            catch
            {
                numerOfCurrentMusic = 0;
            }
        }

        //Forward
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try 
            { 
                numerOfCurrentMusic ++;
                wplayer.URL = FileNamesOfMusic[numerOfCurrentMusic];
                MusicLabelCounter[numerOfCurrentMusic].ForeColor = Color.PowderBlue;
                MusicLabelCounter[numerOfCurrentMusic].BackColor = Color.FromArgb(51, 83, 188);
                MusicLabelCounter[numerOfCurrentMusic - 1].ForeColor = Color.FromArgb(51, 83, 188);
                MusicLabelCounter[numerOfCurrentMusic - 1].BackColor = Color.PowderBlue;
                wplayer.controls.play();
                if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {

                    wplayer.controls.play();

                }
            }
            catch
            {
                numerOfCurrentMusic = 0;
            }
        }

        //Repeat
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (alternator == false) {
                pictureBox5.BackColor = Color.FromArgb(51, 83, 188);
                alternator = true;
                wplayer.settings.setMode("loop", true);
            }
            else if (alternator == true)
            {
                pictureBox5.BackColor = Color.PowderBlue;
                alternator = false;
                wplayer.settings.setMode("loop", false);
            }
        }

        //Randomise
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            numerOfCurrentMusic = rand.Next(0, FileNamesOfMusic.Length);
            wplayer.URL = FileNamesOfMusic[numerOfCurrentMusic];
            for (int i = 0; i < MusicLabelCounter.Length; i++)
            {
                if (i == numerOfCurrentMusic)
                {
                    MusicLabelCounter[i].ForeColor = Color.PowderBlue;
                    MusicLabelCounter[i].BackColor = Color.FromArgb(51, 83, 188);
                }
                else if (i != numerOfCurrentMusic)
                {
                    MusicLabelCounter[i].ForeColor = Color.FromArgb(51, 83, 188);
                    MusicLabelCounter[i].BackColor = Color.PowderBlue;
                }
            }
            wplayer.controls.play();
            if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {

                wplayer.controls.play();

            }
        }

        private void Muzyka_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileNamesOfMusic.Length; i++)
            {
                label4.Text += FileNamesOfMusic[i];
            }
        }
    }
}
