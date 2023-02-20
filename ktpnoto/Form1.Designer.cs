
namespace ktpnoto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.yuvarlakButon3 = new ktpnoto.yuvarlakButon();
            this.yuvarlakButon2 = new ktpnoto.yuvarlakButon();
            this.yuvarlakButon1 = new ktpnoto.yuvarlakButon();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 10;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 10;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // yuvarlakButon3
            // 
            this.yuvarlakButon3.BackColor = System.Drawing.Color.Black;
            this.yuvarlakButon3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.yuvarlakButon3, "yuvarlakButon3");
            this.yuvarlakButon3.ForeColor = System.Drawing.Color.White;
            this.yuvarlakButon3.Name = "yuvarlakButon3";
            this.yuvarlakButon3.UseVisualStyleBackColor = false;
            this.yuvarlakButon3.Click += new System.EventHandler(this.yuvarlakButon3_Click);
            this.yuvarlakButon3.MouseEnter += new System.EventHandler(this.yuvarlakButon3_MouseEnter);
            this.yuvarlakButon3.MouseLeave += new System.EventHandler(this.yuvarlakButon3_MouseLeave);
            // 
            // yuvarlakButon2
            // 
            this.yuvarlakButon2.BackColor = System.Drawing.Color.Black;
            this.yuvarlakButon2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.yuvarlakButon2, "yuvarlakButon2");
            this.yuvarlakButon2.ForeColor = System.Drawing.Color.White;
            this.yuvarlakButon2.Name = "yuvarlakButon2";
            this.yuvarlakButon2.UseVisualStyleBackColor = false;
            this.yuvarlakButon2.Click += new System.EventHandler(this.yuvarlakButon2_Click);
            this.yuvarlakButon2.MouseEnter += new System.EventHandler(this.yuvarlakButon2_MouseEnter);
            this.yuvarlakButon2.MouseLeave += new System.EventHandler(this.yuvarlakButon2_MouseLeave);
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.BackColor = System.Drawing.Color.Black;
            this.yuvarlakButon1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.yuvarlakButon1, "yuvarlakButon1");
            this.yuvarlakButon1.ForeColor = System.Drawing.Color.White;
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.UseVisualStyleBackColor = false;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            this.yuvarlakButon1.MouseEnter += new System.EventHandler(this.yuvarlakButon1_MouseEnter);
            this.yuvarlakButon1.MouseLeave += new System.EventHandler(this.yuvarlakButon1_MouseLeave);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.yuvarlakButon3);
            this.Controls.Add(this.yuvarlakButon2);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private yuvarlakButon yuvarlakButon1;
        private yuvarlakButon yuvarlakButon2;
        private yuvarlakButon yuvarlakButon3;
    }
}

