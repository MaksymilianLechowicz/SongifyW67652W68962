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
    public partial class Namer : Form
    {
        public static Namer instance;
        public Button b1;
        public Button b2;
        public Namer()
        {
            InitializeComponent();
            instance = this;
            b1 = button1;
            b2 = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.instance.PlaylistName = PlayListNamer.Texts;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("PlaylistDirectory\\" + PlayListNamer.Texts);
            this.Close();
        }
    }
}
