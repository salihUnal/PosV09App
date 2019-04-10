namespace Pos_V9
{
    using Pos_V9.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form2 : Form
    {
        private SqlConnection baglan = new SqlConnection();
        private Button button1;
        private IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;

        public Form2()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!");
            }
            try
            {
                this.baglan.ConnectionString = "User ID=POS;Password=P0s2441664;Persist Security Info=True;Initial Catalog=Pos_Connection;Data Source=172.16.80.17;pooling=true; connection lifetime=10; connection timeout=5; packet size=1024;";
                try
                {
                    if (this.baglan.State == ConnectionState.Closed)
                    {
                        this.baglan.Open();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Veritabanına Bağlanamıyorsun. Network Ayarlarını Kontrol Et!!!...");
                }
                SqlParameter parameter = new SqlParameter("@KAdi", this.textBox1.Text);
                SqlParameter parameter2 = new SqlParameter("@KSifre", this.textBox2.Text);
                string cmdText = "Select*from USER_INFO where USER_NAME=@KAdi AND PASSWORD=@KSifre";
                SqlCommand selectCommand = new SqlCommand(cmdText, this.baglan);
                selectCommand.Parameters.Add(parameter);
                selectCommand.Parameters.Add(parameter2);
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(selectCommand).Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Hoşgeldin " + this.textBox1.Text);
                    base.Hide();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Veritabanında b\x00f6yle bir kullanıcı bulunamadı");
                }
            }
            catch (Exception)
            {
                this.baglan.Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form2));
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.label3 = new Label();
            base.SuspendLayout();
            this.textBox1.ForeColor = SystemColors.ActiveCaptionText;
            this.textBox1.Location = new Point(0x99, 0x25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox2.ForeColor = SystemColors.ActiveCaptionText;
            this.textBox2.Location = new Point(0x99, 0x40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = SystemColors.ActiveCaptionText;
            this.label1.Location = new Point(0x3e, 0x2c);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı_Adı     :";
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.ForeColor = SystemColors.ActiveCaptionText;
            this.label2.Location = new Point(0x3e, 0x47);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre                  :";
            this.button1.BackgroundImageLayout = ImageLayout.None;
            this.button1.Cursor = Cursors.Hand;
            this.button1.ForeColor = SystemColors.ActiveCaptionText;
            this.button1.Location = new Point(0x99, 0x73);
            this.button1.Name = "button1";
            this.button1.Size = new Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Century Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = SystemColors.AppWorkspace;
            this.label3.Location = new Point(0xf3, 0xe4);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x40, 0x11);
            this.label3.TabIndex = 5;
            this.label3.Text = "vers.1605";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.LoginRed;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x135, 0xf8);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "Form2";
            this.Text = "POS_V9_Login";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

