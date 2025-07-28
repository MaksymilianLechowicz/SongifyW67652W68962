namespace Songify
{
    partial class Namer
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            PlayListNamer = new CustomControls.RJControls.RoundTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 33, 112);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PlayListNamer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 181);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(223, 132);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(304, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Finish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(51, 83, 188);
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Playlist name";
            // 
            // PlayListNamer
            // 
            PlayListNamer.BackColor = SystemColors.Window;
            PlayListNamer.BorderColor = Color.FromArgb(51, 83, 188);
            PlayListNamer.BorderFocusColor = Color.PowderBlue;
            PlayListNamer.BorderRadius = 10;
            PlayListNamer.BorderSize = 2;
            PlayListNamer.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayListNamer.ForeColor = Color.FromArgb(64, 64, 64);
            PlayListNamer.Location = new Point(81, 78);
            PlayListNamer.Margin = new Padding(4);
            PlayListNamer.Multiline = false;
            PlayListNamer.Name = "PlayListNamer";
            PlayListNamer.Padding = new Padding(10, 7, 10, 7);
            PlayListNamer.PasswordChar = false;
            PlayListNamer.PlaceholderColor = Color.DarkGray;
            PlayListNamer.PlaceholderText = "Input Playlist name here";
            PlayListNamer.Size = new Size(250, 31);
            PlayListNamer.TabIndex = 0;
            PlayListNamer.Texts = "";
            PlayListNamer.UnderlinedStyle = false;
            // 
            // Namer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 181);
            Controls.Add(panel1);
            Name = "Namer";
            Text = "Namer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomControls.RJControls.RoundTextBox PlayListNamer;
        private Button button1;
        private Button button2;
    }
}