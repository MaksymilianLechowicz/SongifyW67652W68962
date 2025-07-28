using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songify
{
    public partial class Settings : Form
    {
        public string PlaylistName;
        public static Settings instance;
        public Settings()
        {
            InitializeComponent();
            instance = this;
            PlaylistName = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Zapis playlisty
        private void button1_Click(object sender, EventArgs e)
        {
            
            Namer namerNow = new Namer();
            Namer.instance.b1.Visible = true;
            Namer.instance.b2.Visible = false;
            namerNow.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                int LengthOfIt = openFileDialog1.FileNames.Length;

                StreamWriter filenamewriter = new StreamWriter("PlaylistDirectory\\" + PlaylistName);
                for (int i = 0; i < LengthOfIt; i++)
                {

                    filenamewriter.Write(Path.GetFileName(openFileDialog1.FileNames[i]) + "\r\n");
                }
                filenamewriter.Close();
            }
            Namer.instance.b1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Namer namerForDelete = new Namer();
            Namer.instance.b1.Visible = false;
            Namer.instance.b2.Visible = true;
            namerForDelete.ShowDialog();
            
        }
    }
}
