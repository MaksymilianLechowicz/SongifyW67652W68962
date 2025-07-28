
namespace Songify
{
    partial class Songify
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songify));
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            LoginButton = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            Login = new RoundControl();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(9, 33, 112);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(rjTextBox2);
            tabPage1.Controls.Add(rjTextBox1);
            tabPage1.Controls.Add(LoginButton);
            tabPage1.Controls.Add(label1);
            tabPage1.ForeColor = Color.FromArgb(51, 83, 188);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PowderBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 77);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(174, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 84);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.PowderBlue;
            rjTextBox2.BorderColor = Color.FromArgb(51, 83, 188);
            rjTextBox2.BorderFocusColor = Color.PowderBlue;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(268, 137);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.Transparent;
            rjTextBox2.PlaceholderText = "Email lub Nazwa Uzytkownika";
            rjTextBox2.Size = new Size(308, 40);
            rjTextBox2.TabIndex = 5;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            rjTextBox2._TextChanged += rjTextBox2__TextChanged;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.PowderBlue;
            rjTextBox1.BorderColor = Color.FromArgb(51, 83, 188);
            rjTextBox1.BorderFocusColor = Color.PowderBlue;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(268, 220);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = true;
            rjTextBox1.PlaceholderColor = Color.Transparent;
            rjTextBox1.PlaceholderText = "Hasło";
            rjTextBox1.Size = new Size(308, 40);
            rjTextBox1.TabIndex = 4;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.PowderBlue;
            LoginButton.ForeColor = Color.FromArgb(9, 33, 112);
            LoginButton.Location = new Point(328, 297);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(119, 37);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.PowderBlue;
            label1.Location = new Point(326, 68);
            label1.Name = "label1";
            label1.Size = new Size(121, 39);
            label1.TabIndex = 2;
            label1.Text = "Songify";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            Login.CueText = "";
            Login.Location = new Point(330, 150);
            Login.Name = "Login";
            Login.Size = new Size(150, 150);
            Login.TabIndex = 0;
            // 
            // Songify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Songify";
            Text = "Songify";
            Load += Songify_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private TabPage tabPage1;
        private TabControl tabControl1;
        private Button LoginButton;
        private Label label1;
        
        private RoundControl Password;
        private RoundControl Login;
        private TextBox textBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
