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
    public partial class uyeIslemleri : Form
    {
        public uyeIslemleri()
        {
            InitializeComponent();
        }
      
        int sayac = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }
        DBBaglanti dBBaglanti = new DBBaglanti();
        bool Mov;
        int MovX, MovY;
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void uyeIslemleri_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void uyeIslemleri_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void uyeIslemleri_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void viewData(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, dBBaglanti.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                Controls.Remove(textBox1);
                Controls.Remove(textBox2);
                Controls.Remove(textBox3);
                Controls.Remove(textBox4);
                Controls.Remove(comboBox1);
                Controls.Remove(panel1);
                Controls.Remove(panel2);
                Controls.Remove(panel3);
                Controls.Remove(panel4);
                Controls.Remove(panel5);
                Controls.Remove(pictureBox1);
                Controls.Remove(pictureBox2);
                Controls.Remove(pictureBox3);
                Controls.Remove(pictureBox4);
                Controls.Remove(pictureBox5);
                Controls.Remove(dataGridView1);
                Controls.Remove(button4);
                Controls.Remove(button5);
                Controls.Remove(yuvarlakButon1);
                Controls.Remove(yuvarlakButon2);
                Controls.Remove(yuvarlakButon3);
                Controls.Remove(yuvarlakButon4);
                Controls.Remove(button1);
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(200, 100);
                pictureBox6.Size = new Size(330, 250);
            }
            else if (sayac == 4)
            {
                Controls.Remove(pictureBox6);
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

        private void yuvarlakButon1_MouseHover(object sender, EventArgs e)
        {

        }

        private void yuvarlakButon1_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Red;
            //label1.Left -= 50;
            //label2.Left += 50;
            //yuvarlakButon2.Top += 50;
            //yuvarlakButon3.Top += 50;
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into uyeler(AdSoyad,Yas,Telefon,Mail,OgrDurum) values(@p1,@p2,@p3,@p4,@p5)", dBBaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.ExecuteNonQuery();
            viewData("select * from uyeler");

            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewCellStyle ColumnRenk;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnRenk = dataGridView1.Columns[0].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;
            ColumnRenk = dataGridView1.Columns[1].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;
            ColumnRenk = dataGridView1.Columns[2].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;
            ColumnRenk = dataGridView1.Columns[3].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;
            ColumnRenk = dataGridView1.Columns[4].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;
            ColumnRenk = dataGridView1.Columns[5].HeaderCell.Style;
            ColumnRenk.BackColor = Color.Black;
            ColumnRenk.ForeColor = Color.White;

        }

        private void yuvarlakButon1_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon1.BackColor = Color.Black;
            //label1.Left += 50;
            //label2.Left -= 50;

        }

        private void yuvarlakButon2_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon2.BackColor = Color.Red;
        }

        private void yuvarlakButon2_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon2.BackColor = Color.Black;
        }

        private void yuvarlakButon4_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon4.BackColor = Color.Red;
        }

        private void yuvarlakButon4_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon4.BackColor = Color.Black;
        }

        private void yuvarlakButon3_MouseEnter(object sender, EventArgs e)
        {
            yuvarlakButon3.BackColor = Color.Red;
        }

        private void yuvarlakButon3_MouseLeave(object sender, EventArgs e)
        {
            yuvarlakButon3.BackColor = Color.Black;
        }

        private void textBox1_CausesValidationChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanici Adi...")
            {

                textBox1.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("Delete  from uyeler where AdSoyad=@p1", dBBaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            viewData("select * from uyeler");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string yas = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string tel = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
            string mail = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();
            string ogrDurum = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
            

            textBox1.Text = ad;
            textBox2.Text = yas;
            textBox3.Text = tel;
            textBox4.Text = mail;
            comboBox1.Text = ogrDurum;
        }
        
        private void yuvarlakButon3_Click(object sender, EventArgs e)
        {
            int seciliAlann = dataGridView1.SelectedCells[0].RowIndex;
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("update uyeler set AdSoyad='"+textBox1.Text+"',Yas='"+ Convert.ToInt32(textBox2.Text)+"',Telefon='"+textBox3.Text+"',Mail='"+textBox4.Text+"',OgrDurum='"+comboBox1.Text+"' where AdSoyad='" + dataGridView1.Rows[seciliAlann].Cells[1].Value.ToString() + "'", dBBaglanti.baglanti());
            
            komut.ExecuteNonQuery();
            viewData("select * from uyeler");
            dBBaglanti.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void yuvarlakButon4_Click(object sender, EventArgs e)
        {
            dBBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("select * from uyeler where AdSoyad like '%" +textBox1.Text+"%' ",dBBaglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dBBaglanti.baglanti().Close();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) == 23)
            {

                textBox2.Clear();
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "53* *** ** **")
            {

                textBox3.Clear();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text== "...@gmail.com")
            {
                textBox4.Clear();
            }
        }

        
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void uyeIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            viewData("Select * from uyeler");
            dBBaglanti.baglanti().Close();
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            comboBox1.SelectedIndex = 2;
            dataGridView1.ReadOnly = true;

        }
    }
}
