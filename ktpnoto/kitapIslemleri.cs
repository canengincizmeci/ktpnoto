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
    public partial class kitapIslemleri : Form
    {
        public kitapIslemleri()
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
        private void kitapIslemleri_Load(object sender, EventArgs e)
        {
            viewData("select * from kitaplar");

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Navy;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[4].Visible = false;
           

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
                Controls.Remove(label1);
                Controls.Remove(label2);
                Controls.Remove(label3);
                Controls.Remove(textBox1);
                Controls.Remove(textBox2);
                Controls.Remove(textBox3);
                Controls.Remove(panel1);
                Controls.Remove(panel2);
                Controls.Remove(panel3);
                Controls.Remove(label4);
                Controls.Remove(button1);
                Controls.Remove(button4);
                Controls.Remove(dataGridView1);
                Controls.Remove(yuvarlakButon1);
                Controls.Remove(yuvarlakButon2);
                Controls.Remove(yuvarlakButon3);
                Controls.Remove(yuvarlakButon4);
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

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("delete from kitaplar where [Kitap Ad]=@p1", dBBaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            viewData("select * from kitaplar");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
        }

     

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into kitaplar ([Kitap Ad],[Kitap Yazar],[Kitap Sayfa]) values(@p1,@p2,@p3)", dBBaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.ExecuteNonQuery();
            viewData("select * from kitaplar");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void yuvarlakButon4_Click(object sender, EventArgs e)
        {
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("select * from kitaplar where [Kitap Ad] like '%" + textBox1.Text + "%'", dBBaglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dBBaglanti.baglanti().Close();
        }

        private void kitapIslemleri_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void kitapIslemleri_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void kitapIslemleri_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
            string kitapAd = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string yazar = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string sayfaSayisi = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();



            textBox1.Text = kitapAd;
            textBox2.Text = yazar;
            textBox3.Text = sayfaSayisi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void yuvarlakButon3_Click(object sender, EventArgs e)
        {
            int seciliAlann = dataGridView1.SelectedCells[0].RowIndex;
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("update kitaplar set [Kitap Ad]='" + textBox1.Text + "',[Kitap Yazar]='" + textBox2.Text + "',[Kitap Sayfa]='" + textBox3.Text + "' where [Kitap Ad]='" + dataGridView1.Rows[seciliAlann].Cells[1].Value.ToString() + "'", dBBaglanti.baglanti());
            komut.ExecuteNonQuery();
            viewData("select * from kitaplar");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}
