using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songify
{
    internal class PlaylistInList
    {
        public string file { get; set; }
        public PlaylistInList(string file)
        {
            this.file = file;
        }
        private int ctnr = MusicOpener.instance.counterForPlaylist;
        string pathForDirectory;
        public void AddList()
        {
            string placeholder;
            int yd = ctnr;
            string pathToMusic = "";
            Array.Resize(ref MusicOpener.instance.FileNamesOfMusic, ctnr + 1);
            MusicOpener.instance.FileNamesOfMusic[ctnr] = pathToMusic;
            string playlistnameInside = Path.GetFileName(MusicOpener.instance.playlistname);
            Label PlayListLabel = new Label
            {
                Size = new Size(170, 100),
                Location = new Point(0, 0 + 25 * (yd)),
                Text = playlistnameInside
            };
            PlayListLabel.Click += ChooseMusic;
            int MusicInPlaylistCounter = ctnr;
            void ChooseMusic(object sender, EventArgs e)
            {
                PlayListLabel.ForeColor = Color.PowderBlue;
                PlayListLabel.BackColor = Color.FromArgb(51, 83, 188);
                StreamReader stream = new StreamReader(file);
                while ((placeholder = stream.ReadLine()) != null)
                {
                    placeholder = stream.ReadLine();
                    SongInList songToTest = new SongInList(placeholder);
                    songToTest.AddList();
                    MusicOpener.instance.counter++;
                }
                    for (int i = 0; i < MusicOpener.instance.PlaylistLabelCounter.Length; i++)
                {
                    if (i != ctnr)
                    {
                        MusicOpener.instance.PlaylistLabelCounter[i].ForeColor = Color.FromArgb(51, 83, 188);
                        MusicOpener.instance.PlaylistLabelCounter[i].BackColor = Color.PowderBlue;
                    }
                }
            }
            
            Array.Resize(ref MusicOpener.instance.PlaylistLabelCounter, ctnr + 1);
            MusicOpener.instance.PlaylistLabelCounter[ctnr] = PlayListLabel;
            MusicOpener.instance.p3.Controls.Add(PlayListLabel);
            PlayListLabel.BringToFront();
            Array.Resize(ref MusicOpener.instance.FileNamesOfMusic, ctnr + 1);
        }
    }
}

