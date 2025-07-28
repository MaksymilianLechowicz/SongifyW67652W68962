using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songify
{
    internal class SongInList
    {

        public string file { get; set; }
        public SongInList(string file)
        {
            this.file = file;
        }
        private int ctnr = MusicOpener.instance.counter;
        string pathForDirectory;
        public void AddList()
        {
            int yd = ctnr;
            string pathToMusic = file;
            MusicOpener.instance.startOrStop = false;
            Array.Resize(ref MusicOpener.instance.FileNamesOfMusic, ctnr + 1);
            MusicOpener.instance.FileNamesOfMusic[ctnr] = "Songs\\" + pathToMusic;
            Label MusicLabel = new Label
            {
                Size = new Size(170, 100),
                Location = new Point(0, 0 + 25 * (yd)),
                Text = Path.GetFileName(pathToMusic)
            };
            MusicLabel.Click += ChooseMusic;
            int MusicInPlaylistCounter = ctnr;
            void ChooseMusic(object sender, EventArgs e)
            {
                MusicLabel.ForeColor = Color.PowderBlue;
                MusicLabel.BackColor = Color.FromArgb(51, 83, 188);
                MusicOpener.instance.currentmusic = file;
                MusicOpener.instance.numerOfCurrentMusic = ctnr;
                for (int i = 0; i < MusicOpener.instance.MusicLabelCounter.Length; i++)
                {
                    if (i != ctnr)
                    {
                        MusicOpener.instance.MusicLabelCounter[i].ForeColor = Color.FromArgb(51, 83, 188);
                        MusicOpener.instance.MusicLabelCounter[i].BackColor = Color.PowderBlue;
                    }
                }
            }
            Array.Resize(ref MusicOpener.instance.MusicLabelCounter, ctnr + 1);
            MusicOpener.instance.MusicLabelCounter[ctnr] = MusicLabel;
            MusicOpener.instance.p6.Controls.Add(MusicLabel);
            MusicLabel.BringToFront();
            Array.Resize(ref MusicOpener.instance.FileNamesOfMusic, ctnr + 1);
            }
        }
    }
