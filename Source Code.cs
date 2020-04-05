// Created BY Sajen Vasuthevan


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        float x;
        float y;
        float ans;
        static int screen = 1;

        public Form1()
        {
            InitializeComponent();

            timer1.Start();

            panel2.Location = new Point(
            this.ClientSize.Width / 2 - panel2.Size.Width / 2,
            this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
            this.WindowState = FormWindowState.Normal;
            screen = 1;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            ans = x + y;
            answer();
        }

        private void answer()
        {
            label1.Text = "Total: " + ans;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);

            ans = x - y;
            answer();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);

            ans = x * y;
            answer();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);

            ans = x / y;
            answer();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string temp = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double val = Math.Pow(a, b);

            string str = val.ToString(temp);

            ans = float.Parse(str);


            answer();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "Total: ";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string temp = "";
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double val = Math.Pow(a, 1/b);

            string str = val.ToString(temp);

            ans = float.Parse(str);


            answer();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (screen == 1)
            {
                screen = 0;
            }
            else
            {
                screen = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (screen == 1)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (screen == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if((!Char.IsDigit(chr)) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if ((!Char.IsDigit(chr)) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
