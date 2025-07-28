using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Songify
{
    public partial class RoundControl : UserControl
    {
        public RoundControl()
         : base()
        { }
        public int rdus = 15;
        public event EventHandler CueTextChanged;
        private string _cueText;

        public string CueText
        {
            get { return _cueText; }
            set
            {
                value = value ?? string.Empty;
                if (value != _cueText)
                {
                    _cueText = value;
                    OnCueTextChanged(EventArgs.Empty);
                }
            }
        }
        protected virtual void OnCueTextChanged(EventArgs e)
        {
            this.Invalidate(true);
            if (this.CueTextChanged != null)
                this.CueTextChanged(this, e);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                ChangeTextBoxtoWatermark();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "username")
            {
                textBox1.Text = "";
                textBox1.Font = new Font(this.Font, FontStyle.Regular);
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                ChangeTextBoxtoWatermark();
        }

        private void ChangeTextBoxtoWatermark()
        {
            textBox1.Font = new Font(this.Font, FontStyle.Italic);
            textBox1.BackColor = Color.LightYellow;
            textBox1.Text = "username";
        }

        System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
            if (string.IsNullOrEmpty(this.Text.Trim()) && !string.IsNullOrEmpty(this.CueText) && !this.Focused)
            {
                Point startingPoint = new Point(0, 0);
                StringFormat format = new StringFormat();
                Font font = new Font(this.Font.FontFamily.Name, this.Font.Size, FontStyle.Italic);
                if (this.RightToLeft == RightToLeft.Yes)
                {
                    format.LineAlignment = StringAlignment.Far;
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                }
                e.Graphics.DrawString(CueText, font, Brushes.Gray, this.ClientRectangle, format);
            }
        }
        private System.Windows.Forms.TextBox textBox1;

        private void InitializeComponent()
        {
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "test";
            // 
            // RoundControl
            // 
            Controls.Add(textBox1);
            Name = "RoundControl";
            Size = new Size(209, 42);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}