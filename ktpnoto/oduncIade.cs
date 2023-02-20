using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ktpnoto
{
    public partial class oduncIade : Form
    {
        public oduncIade()
        {
            InitializeComponent();
        }
        DBBaglanti dBBaglanti = new DBBaglanti();
        int sayac = 0;
        bool Mov;
        int MovX, MovY;
        private void viewData(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, dBBaglanti.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void viewData2(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, dBBaglanti.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void viewData3(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, dBBaglanti.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }


        private void oduncIade_Load(object sender, EventArgs e)
        {
            //   viewData("select [Kitap ID],[Kitap Ad],[Kitap Yazar],[Kitap Sayfa] from kitaplar");
            viewData("select * from kitaplar");
            dataGridView1.Columns["Kitap Durum"].Visible = false;
            viewData2("select * from uyeler");
            viewData3("select * from islemler");
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;




        }

        private void oduncIade_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void oduncIade_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void oduncIade_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void yuvarlakButon1_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Red;
        }

        private void yuvarlakButon1_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Black;
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            bool rafdurum = false;
            if (comboBox1.Text == "rafta")
            {
                rafdurum = true;
            }
            if (comboBox1.Text == "ödünç")
            {
                rafdurum = false;
            }
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("update kitaplar set [Kitap Durum]='" + rafdurum + "' where [Kitap Ad]='" + textBox2.Text + "'", dBBaglanti.baglanti());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("insert into islemler (uyeid,kitapid) values (@p1,@p2)", dBBaglanti.baglanti());
            komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
            komut2.Parameters.AddWithValue("@p2", Convert.ToInt32(textBox2.Text));
            komut2.ExecuteNonQuery();
            viewData("select * from kitaplar");
            viewData2("select * from uyeler");
            viewData3("select * from islemler");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                Controls.Remove(dataGridView1);
                Controls.Remove(dataGridView2);
                Controls.Remove(dataGridView3);
                Controls.Remove(label1);
                Controls.Remove(label2);
                Controls.Remove(label3);
                Controls.Remove(label4);
                Controls.Remove(yuvarlakButon1);
                Controls.Remove(button1);
                Controls.Remove(button4);
                Controls.Remove(textBox1);
                Controls.Remove(textBox2);
                Controls.Remove(comboBox1);
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(200, 100);
                pictureBox1.Size = new Size(330, 250);
            }
            else if (sayac == 2)
            {
                Controls.Remove(pictureBox1);
                this.BackColor = Color.Red;
            }
            else if (sayac == 3)
            {
                Application.Exit();
            }
        }

      

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView2.SelectedCells[0].RowIndex;

            string kitapidd = dataGridView2.Rows[seciliAlan].Cells[0].Value.ToString();
            textBox1.Text = kitapidd;

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;

            int kitapAd = Convert.ToInt32(dataGridView1.Rows[seciliAlan].Cells[0].Value);

            bool rafDurum = Convert.ToBoolean(dataGridView1.Rows[seciliAlan].Cells[4].Value);

            textBox2.Text = kitapAd.ToString();


            if (rafDurum == true)
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (rafDurum == false)
            {
                comboBox1.SelectedIndex = 1;
            }
        }

       
    }
}
