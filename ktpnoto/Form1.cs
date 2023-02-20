using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktpnoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        bool Mov;
        int MovX, MovY;
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                Controls.Remove(yuvarlakButon1);
                Controls.Remove(yuvarlakButon2);
                Controls.Remove(yuvarlakButon3);
                Controls.Remove(label1);
                Controls.Remove(button4);
                Controls.Remove(button5);
                Controls.Remove(label2);
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(200, 100);
                pictureBox1.Size = new Size(330, 250);
            }
            else if (sayac == 4)
            {
                Controls.Remove(pictureBox1);
                this.BackColor = Color.Red;
            }
            else if (sayac == 5)
            {
                Application.Exit();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            oduncIade odunc = new oduncIade();
            odunc.Show();
            this.Hide();
        }


        private void yuvarlakButon1_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Black;
            //label1.Left += 50;
            //label2.Left -= 50;
            yuvarlakButon2.Top -= 50;
            yuvarlakButon3.Top -= 50;
        }



        private void yuvarlakButon2_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon2.BackColor = Color.Black;
            //label1.Left += 50;
            //label2.Left -= 50;
            yuvarlakButon1.Top -= 50;
            yuvarlakButon3.Top -= 50;
        }


        private void yuvarlakButon3_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon3.BackColor = Color.Black;
            //label1.Left += 50;
            //label2.Left -= 50;
            yuvarlakButon1.Top -= 50;
            yuvarlakButon2.Top -= 50;
        }

        private void yuvarlakButon1_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Red;
            //label1.Left -= 50;
            //label2.Left += 50;
            yuvarlakButon2.Top += 50;
            yuvarlakButon3.Top += 50;
        }

        private void yuvarlakButon2_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon2.BackColor = Color.Red;
            //label1.Left -= 50;
            //label2.Left += 50;
            yuvarlakButon1.Top += 50;
            yuvarlakButon3.Top += 50;
        }

        private void yuvarlakButon3_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon3.BackColor = Color.Red;
            //label1.Left -= 50;
            //label2.Left += 50;
            yuvarlakButon1.Top += 50;
            yuvarlakButon2.Top += 50;
        }

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            uyeIslemleri uye = new uyeIslemleri();
            uye.Show();
            this.Hide();
        }

        private void yuvarlakButon3_Click(object sender, EventArgs e)
        {
            kitapIslemleri kitap = new kitapIslemleri();
            kitap.Show();
            this.Hide();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
