namespace Songify
{
    partial class MusicOpener
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicOpener));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            Muzyka = new Label();
            Songify = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 33, 112);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(rjTextBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(51, 83, 188);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(686, 103);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(25, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 82);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.PowderBlue;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(244, 363);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 75);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.PowderBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(313, 352);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(87, 86);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.PowderBlue;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(549, 352);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 86);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.PowderBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(467, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 86);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.PowderBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(393, 352);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 86);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.PowderBlue;
            rjTextBox1.BorderColor = Color.FromArgb(51, 83, 188);
            rjTextBox1.BorderFocusColor = Color.PowderBlue;
            rjTextBox1.BorderRadius = 30;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Enabled = false;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 54.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(222, 348);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(429, 98);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(Songify);
            panel4.Location = new Point(210, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 296);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(435, 214);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(Muzyka);
            panel6.Location = new Point(9, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 544);
            panel6.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(51, 83, 188);
            label1.ForeColor = Color.PowderBlue;
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Muzyka wybrana";
            // 
            // Muzyka
            // 
            Muzyka.AutoSize = true;
            Muzyka.Location = new Point(3, 10);
            Muzyka.Name = "Muzyka";
            Muzyka.Size = new Size(48, 15);
            Muzyka.TabIndex = 0;
            Muzyka.Text = "Muzyka";
            Muzyka.Click += Muzyka_Click;
            // 
            // Songify
            // 
            Songify.AutoSize = true;
            Songify.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 238);
            Songify.Location = new Point(169, 14);
            Songify.Name = "Songify";
            Songify.Size = new Size(110, 40);
            Songify.TabIndex = 0;
            Songify.Text = "Songify";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(9, 33, 112);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 269);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(13, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(88, 425);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(51, 83, 188);
            label2.ForeColor = Color.PowderBlue;
            label2.Location = new Point(0, 24);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Playlista wybrana";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Playlista";
            // 
            // MusicOpener
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MusicOpener";
            Text = "MusicOpener";
            Load += MusicOpener_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label Songify;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Label Muzyka;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}