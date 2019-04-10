namespace Pos_V9
{
    using Pos_V9.Properties;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private SqlConnection baglanti = new SqlConnection("User ID=POS;Password=P0s2441664;Persist Security Info=True;Initial Catalog=Pos_Connection;Data Source=172.16.80.17");
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox1;
        private TextBox textBox4;
        private Timer timer1;
        private WebBrowser webBrowser1;
        private WebBrowser webBrowser2;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urlString = "http://sd.pos.com.tr/Servicemanagement/AutoDeploy/Orion.Apploader.application?AutoConnectConnectionName=FRSServer&ClickOnceDeploy=true&AutoConnect=true&AutoConnectDescription=FRSApp&CacheLevel=ALL&AutoConnectConnectionId=FRS92E9135&ampCompressionLevel=3&AutoConnectAppServerUrl=";
            this.webBrowser2.Navigate(urlString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urlString = "http://172.16.60.10";
            this.webBrowser2.Navigate(urlString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string urlString = "http://10.133.26.101/lisanstalep/lisanstalep.wgx";
            this.webBrowser2.Navigate(urlString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = @"C:\Windows\System32\mstsc.exe";
            new Process { StartInfo = { FileName = str } }.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string urlString = "http://10.133.26.101/lisans/lisans.wgx";
            this.webBrowser2.Navigate(urlString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cmdText = "select * from FOHW ORDER BY GSM_NO";
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand(cmdText, this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            this.dataGridView6.DataSource = dataTable;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cmdText = "select TEKNIK_UZMAN , KISA_KOD,GSM,IL from NOBETCI_TEL WHERE NOBET = 1";
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand(cmdText, this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            this.dataGridView7.DataSource = dataTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM POS_IRT WHERE B\x00d6L\x00dcM\x00dc='" + this.comboBox1.SelectedItem + "'";
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand(cmdText, this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            this.dataGridView6.DataSource = dataTable;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM IL_ILCE WHERE Şehir ='" + this.comboBox2.SelectedItem + "'";
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand(cmdText, this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView7.DataSource = dataTable;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select ID,MAGAZA FROM CONN ORDER BY MAGAZA");
                if (this.baglanti.State == ConnectionState.Closed)
                {
                    this.baglanti.Open();
                }
                command.Connection = this.baglanti;
                SqlDataReader reader = command.ExecuteReader();
                this.listBox1.Items.Clear();
                this.label1.Text = "Bağlantı---OK";
                this.label1.ForeColor = Color.Green;
                while (reader.Read())
                {
                    this.listBox1.Items.Add(reader["MAGAZA"]);
                }
                this.baglanti.Close();
            }
            catch
            {
                this.label1.Text = "Bağlantı Yok";
                this.label1.ForeColor = Color.Red;
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.listBox1 = new ListBox();
            this.dataGridView2 = new DataGridView();
            this.dataGridView3 = new DataGridView();
            this.dataGridView4 = new DataGridView();
            this.dataGridView5 = new DataGridView();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.label18 = new Label();
            this.button4 = new Button();
            this.label9 = new Label();
            this.label8 = new Label();
            this.tabPage4 = new TabPage();
            this.webBrowser1 = new WebBrowser();
            this.textBox4 = new TextBox();
            this.dataGridView1 = new DataGridView();
            this.label3 = new Label();
            this.tabPage2 = new TabPage();
            this.button6 = new Button();
            this.label11 = new Label();
            this.label10 = new Label();
            this.comboBox1 = new ComboBox();
            this.textBox1 = new TextBox();
            this.dataGridView6 = new DataGridView();
            this.tabPage3 = new TabPage();
            this.button7 = new Button();
            this.label17 = new Label();
            this.label12 = new Label();
            this.dataGridView7 = new DataGridView();
            this.comboBox2 = new ComboBox();
            this.tabPage5 = new TabPage();
            this.button5 = new Button();
            this.label16 = new Label();
            this.label15 = new Label();
            this.label14 = new Label();
            this.label13 = new Label();
            this.button3 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.webBrowser2 = new WebBrowser();
            this.timer1 = new Timer(this.components);
            ((ISupportInitialize) this.dataGridView2).BeginInit();
            ((ISupportInitialize) this.dataGridView3).BeginInit();
            ((ISupportInitialize) this.dataGridView4).BeginInit();
            ((ISupportInitialize) this.dataGridView5).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((ISupportInitialize) this.dataGridView1).BeginInit();
            this.tabPage2.SuspendLayout();
            ((ISupportInitialize) this.dataGridView6).BeginInit();
            this.tabPage3.SuspendLayout();
            ((ISupportInitialize) this.dataGridView7).BeginInit();
            this.tabPage5.SuspendLayout();
            base.SuspendLayout();
            this.listBox1.BackColor = SystemColors.ControlDarkDark;
            this.listBox1.BorderStyle = BorderStyle.None;
            this.listBox1.ForeColor = Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new Point(6, 0x29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(0x7a, 390);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dataGridView2.BackgroundColor = Color.AliceBlue;
            this.dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            style.Alignment = DataGridViewContentAlignment.TopCenter;
            style.BackColor = SystemColors.ActiveBorder;
            style.Font = new Font("Cambria", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.ActiveBorder;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = style;
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.ActiveBorder;
            style2.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style2.ForeColor = Color.MediumVioletRed;
            style2.SelectionBackColor = SystemColors.ActiveBorder;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = style2;
            this.dataGridView2.Location = new Point(0x89, 0x29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new Size(640, 0x7c);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dataGridView3.BackgroundColor = Color.AliceBlue;
            this.dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = style3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.ActiveBorder;
            style4.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style4.ForeColor = Color.MediumVioletRed;
            style4.SelectionBackColor = SystemColors.ActiveBorder;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = style4;
            this.dataGridView3.Location = new Point(0x89, 0xc7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new Size(0x281, 0x77);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dataGridView4.BackgroundColor = Color.AliceBlue;
            this.dataGridView4.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            style5.BackColor = SystemColors.Control;
            style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style5.ForeColor = SystemColors.WindowText;
            style5.SelectionBackColor = SystemColors.Highlight;
            style5.SelectionForeColor = SystemColors.HighlightText;
            style5.WrapMode = DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = style5;
            this.dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style6.BackColor = SystemColors.ActiveBorder;
            style6.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style6.ForeColor = Color.MediumVioletRed;
            style6.SelectionBackColor = SystemColors.ActiveBorder;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = style6;
            this.dataGridView4.Location = new Point(0x89, 0x164);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new Size(0x281, 0x7d);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dataGridView5.BackgroundColor = Color.AliceBlue;
            this.dataGridView5.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            style7.BackColor = SystemColors.Control;
            style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style7.ForeColor = SystemColors.WindowText;
            style7.SelectionBackColor = SystemColors.Highlight;
            style7.SelectionForeColor = SystemColors.HighlightText;
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = style7;
            this.dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.ActiveBorder;
            style8.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style8.ForeColor = Color.MediumVioletRed;
            style8.SelectionBackColor = SystemColors.ActiveBorder;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = style8;
            this.dataGridView5.Location = new Point(0x8a, 0x20e);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new Size(0x281, 0x73);
            this.dataGridView5.TabIndex = 3;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("OCR A Extended", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(3, 0x319);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection_State";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label2.Location = new Point(-3, 0x19);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = " M\x00fcşteri Se\x00e7imi Yapınız";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label4.Location = new Point(0x86, 0x19);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0xb3, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uzak Terminal Bağlantı Bilgileri";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label5.Location = new Point(0x87, 0xb7);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0xbb, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Merkez Sunucu Bağlantı Bilgileri";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label6.Location = new Point(0x87, 340);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x8e, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mağaza Bağlantı Bilgileri";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label7.Location = new Point(0x87, 0x1fd);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x7d, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kasa Bağlantı Bilgileri";
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new Size(0x321, 0x35b);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabPage1.AccessibleName = "";
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = Color.AliceBlue;
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.ForeColor = Color.MediumVioletRed;
            this.tabPage1.ImageKey = "(none)";
            this.tabPage1.ImeMode = ImeMode.KatakanaHalf;
            this.tabPage1.Location = new Point(4, 0x16);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(0x319, 0x341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PosBağlantıBilgileri";
            this.label18.AutoSize = true;
            this.label18.Font = new Font("Kristen ITC", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label18.ForeColor = SystemColors.WindowFrame;
            this.label18.Location = new Point(4, 0x203);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x1d, 0x21);
            this.label18.TabIndex = 11;
            this.label18.Text = "  ";
            this.button4.FlatStyle = FlatStyle.Popup;
            this.button4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.button4.Location = new Point(0x28d, 170);
            this.button4.Name = "button4";
            this.button4.Size = new Size(0x4b, 0x17);
            this.button4.TabIndex = 10;
            this.button4.Text = "MSTSC";
            this.button4.TextAlign = ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Kristen ITC", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.ForeColor = SystemColors.WindowFrame;
            this.label9.Location = new Point(4, 0x1c1);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x1d, 0x21);
            this.label9.TabIndex = 7;
            this.label9.Text = "  ";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Kristen ITC", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.ForeColor = SystemColors.WindowFrame;
            this.label8.Location = new Point(6, 0x1e2);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x1d, 0x21);
            this.label8.TabIndex = 9;
            this.label8.Text = "  ";
            this.tabPage4.Controls.Add(this.webBrowser1);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new Point(4, 0x16);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Padding(3);
            this.tabPage4.Size = new Size(0x319, 0x341);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Vpn_Baglantısı";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.webBrowser1.Location = new Point(6, 0xcb);
            this.webBrowser1.MinimumSize = new Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new Size(0x2f6, 0x13d);
            this.webBrowser1.TabIndex = 0x11;
            this.textBox4.BorderStyle = BorderStyle.None;
            this.textBox4.Font = new Font("MS Reference Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            this.textBox4.Location = new Point(8, 0xae);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(0x137, 0x10);
            this.textBox4.TabIndex = 0x10;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = Color.AliceBlue;
            this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            style9.BackColor = SystemColors.Control;
            style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style9.ForeColor = SystemColors.WindowText;
            style9.SelectionBackColor = SystemColors.Highlight;
            style9.SelectionForeColor = SystemColors.HighlightText;
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = style9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style10.BackColor = SystemColors.ActiveBorder;
            style10.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xa2);
            style10.ForeColor = Color.MediumVioletRed;
            style10.SelectionBackColor = SystemColors.ActiveBorder;
            style10.SelectionForeColor = SystemColors.HighlightText;
            style10.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = style10;
            this.dataGridView1.Location = new Point(6, 0x35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new Size(0x2f5, 0x73);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.VirtualMode = true;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Candara", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.label3.Location = new Point(5, 0x23);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x7b, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "VPN Bağlantı Bilgileri";
            this.tabPage2.BackColor = SystemColors.ButtonShadow;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.tabPage2.Location = new Point(4, 0x16);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(0x319, 0x341);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Posİrtibat";
            this.button6.BackgroundImageLayout = ImageLayout.None;
            this.button6.FlatStyle = FlatStyle.Popup;
            this.button6.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.button6.Location = new Point(310, 0x17);
            this.button6.Name = "button6";
            this.button6.Size = new Size(0x87, 0x18);
            this.button6.TabIndex = 4;
            this.button6.Text = "FoHW Tel. No";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.label11.Location = new Point(0xa7, 5);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x81, 0x10);
            this.label11.TabIndex = 3;
            this.label11.Text = "Departman'a G\x00f6re";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.label10.Location = new Point(20, 5);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x66, 0x10);
            this.label10.TabIndex = 3;
            this.label10.Text = "İsme G\x00f6re  Bul";
            this.comboBox1.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.comboBox1.ForeColor = SystemColors.MenuHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(170, 0x17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0x79, 0x18);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.textBox1.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.textBox1.Location = new Point(0x17, 0x18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(120, 0x17);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new Point(-4, 0x42);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new Size(0x31d, 0x303);
            this.dataGridView6.TabIndex = 0;
            this.tabPage3.BackColor = SystemColors.AppWorkspace;
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dataGridView7);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa2);
            this.tabPage3.Location = new Point(4, 0x16);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Padding(3);
            this.tabPage3.RightToLeft = RightToLeft.No;
            this.tabPage3.Size = new Size(0x319, 0x341);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Il_Ilce_Tablosu";
            this.button7.FlatStyle = FlatStyle.Flat;
            this.button7.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.button7.Location = new Point(310, 0x17);
            this.button7.Name = "button7";
            this.button7.Size = new Size(0x87, 0x18);
            this.button7.TabIndex = 12;
            this.button7.Text = "İst_N\x00f6bet\x00e7i";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.label17.AutoSize = true;
            this.label17.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            this.label17.Location = new Point(0xa7, 5);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x71, 0x10);
            this.label17.TabIndex = 11;
            this.label17.Text = "İl Se\x00e7imi Yapınız";
            this.label12.AutoSize = true;
            this.label12.Font = new Font("Tempus Sans ITC", 15.75f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label12.Location = new Point(0x1c3, 0x17);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x12, 0x1b);
            this.label12.TabIndex = 2;
            this.label12.Text = ".";
            this.label12.Visible = false;
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new Point(0, 0x42);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.Size = new Size(0x31d, 0x303);
            this.dataGridView7.TabIndex = 10;
            this.comboBox2.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.comboBox2.ForeColor = SystemColors.MenuHighlight;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new Point(170, 0x17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(0x79, 0x18);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
            this.tabPage5.BackColor = Color.Plum;
            this.tabPage5.BackgroundImage = Resources.Uzay;
            this.tabPage5.BackgroundImageLayout = ImageLayout.None;
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.webBrowser2);
            this.tabPage5.Location = new Point(4, 0x16);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new Padding(3);
            this.tabPage5.Size = new Size(0x319, 0x341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Lisans_Sayfası";
            this.button5.BackColor = Color.Transparent;
            this.button5.BackgroundImage = Resources.posas;
            this.button5.BackgroundImageLayout = ImageLayout.Stretch;
            this.button5.FlatStyle = FlatStyle.Popup;
            this.button5.ForeColor = Color.Transparent;
            this.button5.Location = new Point(0x125, 6);
            this.button5.Name = "button5";
            this.button5.Size = new Size(0x4d, 0x49);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.label16.AutoSize = true;
            this.label16.BackColor = Color.Transparent;
            this.label16.ForeColor = SystemColors.ButtonFace;
            this.label16.Location = new Point(0x11c, 0x52);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x61, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "2NF Lisans Sayfası";
            this.label15.AutoSize = true;
            this.label15.BackColor = Color.Transparent;
            this.label15.ForeColor = SystemColors.ButtonFace;
            this.label15.Location = new Point(0xbb, 0x52);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x61, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Eski Lisans Sayfası";
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.Transparent;
            this.label14.ForeColor = SystemColors.ButtonFace;
            this.label14.Location = new Point(0x58, 0x52);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x62, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Yeni Lisans Sayfası";
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.Transparent;
            this.label13.ForeColor = SystemColors.ButtonFace;
            this.label13.Location = new Point(0x1a, 0x52);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x21, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "ITSM";
            this.button3.BackColor = Color.Transparent;
            this.button3.BackgroundImage = Resources.posas;
            this.button3.BackgroundImageLayout = ImageLayout.Stretch;
            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.ForeColor = Color.Transparent;
            this.button3.Location = new Point(0xc4, 6);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x4d, 0x49);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button2.BackColor = Color.Transparent;
            this.button2.BackgroundImage = Resources.posas;
            this.button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.ForeColor = Color.Transparent;
            this.button2.Location = new Point(100, 6);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x4d, 0x49);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.BackColor = Color.Transparent;
            this.button1.BackgroundImage = Resources.webbanner;
            this.button1.BackgroundImageLayout = ImageLayout.None;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.ForeColor = Color.Transparent;
            this.button1.Location = new Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4d, 0x49);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.webBrowser2.Location = new Point(0, 0x86);
            this.webBrowser2.MinimumSize = new Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new Size(0x32b, 0x2bb);
            this.webBrowser2.TabIndex = 0;
            this.timer1.Enabled = true;
            this.timer1.Interval = 0x3e8;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x321, 0x35b);
            base.Controls.Add(this.tabControl1);
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            this.Text = "Pos_V9 vers.1605";
            base.TransparencyKey = Color.FromArgb(0x40, 0, 0x40);
            base.Load += new EventHandler(this.Form1_Load);
            ((ISupportInitialize) this.dataGridView2).EndInit();
            ((ISupportInitialize) this.dataGridView3).EndInit();
            ((ISupportInitialize) this.dataGridView4).EndInit();
            ((ISupportInitialize) this.dataGridView5).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((ISupportInitialize) this.dataGridView1).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((ISupportInitialize) this.dataGridView6).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((ISupportInitialize) this.dataGridView7).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            base.ResumeLayout(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = this.listBox1.GetItemText(this.listBox1.SelectedItem);
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand("select conn.MAGAZA,VPN.VPN,VPN.VPN_URL,VPN.VPN_USERNAME,VPN.VPN_PASSWORD from  CONN INNER JOIN VPN ON VPN.FK_CONN=CONN.ID WHERE MAGAZA = '" + str + "'", this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;
            SqlCommand command2 = new SqlCommand("select DESCRIPTION, RDP_IP_1,RDP_USER_NAME_1,RDP_PASSWORD_1,NOTEPAD FROM RDP WHERE DESCRIPTION = '" + str + "'", this.baglanti);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            this.dataGridView2.DataSource = table2;
            SqlCommand command3 = new SqlCommand("select DESCRIPTION,MERKEZ_IP, MERKEZ_USERNAME,MERKEZ_PASSWORD,NOTE  FROM merkez WHERE DESCRIPTION = '" + str + "'", this.baglanti);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            this.dataGridView3.DataSource = table3;
            SqlCommand command4 = new SqlCommand("SELECT BAGLANTI_PROG,USERNAME,PASSWORD,NOTE FROM MAGAZA WHERE FK_CONN IN(SELECT ID FROM CONN WHERE MAGAZA = '" + str + "')", this.baglanti);
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4);
            DataTable table4 = new DataTable();
            adapter4.Fill(table4);
            this.dataGridView4.DataSource = table4;
            SqlCommand command5 = new SqlCommand("SELECT BAGLANTI_PROG,USERNAME,PASSWORD,NOTE FROM KASA WHERE FK_CONN IN(SELECT ID FROM CONN WHERE MAGAZA = '" + str + "')", this.baglanti);
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5);
            DataTable table5 = new DataTable();
            adapter5.Fill(table5);
            this.dataGridView5.DataSource = table5;
            string cmdText = "select DISTINCT(VPN.VPN_URL) from  CONN INNER JOIN VPN ON VPN.FK_CONN=CONN.ID WHERE MAGAZA = '" + str + "'";
            if (this.listBox1.GetItemText(this.listBox1.SelectedItem) != "KOTON")
            {
                SqlCommand command6 = new SqlCommand(cmdText, this.baglanti);
                this.textBox4.Text = command6.ExecuteScalar().ToString();
                this.webBrowser1.Navigate(this.textBox4.Text);
            }
            if (this.listBox1.GetItemText(this.listBox1.SelectedItem) == "AYDINLI")
            {
                string str10;
                if (Environment.Is64BitOperatingSystem)
                {
                    str10 = @"C:\Program Files (x86)\OpenVPN Technologies\OpenVPN Client\core\ovpntray.exe";
                    Process process = new Process {
                        StartInfo = { FileName = str10 }
                    };
                    process.Start();
                }
                else
                {
                    str10 = @"C:\Program Files\OpenVPN Technologies\OpenVPN Client\core\ovpntray.exe";
                    new Process { StartInfo = { FileName = str10 } }.Start();
                }
            }
            string str11 = this.listBox1.GetItemText(this.listBox1.SelectedItem);
            switch (str11)
            {
                case "TOYPA":
                case "REAL":
                case "EVE":
                    string str12;
                    if (Environment.Is64BitOperatingSystem)
                    {
                        str12 = @"C:\Program Files (x86)\Fortinet\FortiClient\FortiClient.exe";
                        Process process2 = new Process {
                            StartInfo = { FileName = str12 }
                        };
                        process2.Start();
                    }
                    else
                    {
                        str12 = @"C:\Program Files\Fortinet\FortiClient\FortiClient.exe";
                        new Process { StartInfo = { FileName = str12 } }.Start();
                    }
                    break;
            }
            string str13 = this.listBox1.GetItemText(this.listBox1.SelectedItem);
            if (str11 == "TEKZEN")
            {
                string str14;
                if (Environment.Is64BitOperatingSystem)
                {
                    str14 = @"C:\Program Files (x86)\CrSSL\bin\crssl-client.exe";
                    Process process3 = new Process {
                        StartInfo = { FileName = str14 }
                    };
                    process3.Start();
                }
                else
                {
                    str14 = @"C:\Program Files\CrSSL\bin\crssl-client.exe";
                    new Process { StartInfo = { FileName = str14 } }.Start();
                }
            }
            string str15 = this.listBox1.GetItemText(this.listBox1.SelectedItem);
            if (str13 == "KOTON")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe", "https://213.74.123.162/cgi-bin/portal");
                Process.Start(startInfo);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT DISTINCT(B\x00f6l\x00fcm\x00fc) FROM POS_IRT", this.baglanti);
                this.comboBox1.Items.Clear();
                if (this.baglanti.State == ConnectionState.Closed)
                {
                    this.baglanti.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.comboBox1.Items.Add(reader[0].ToString());
                }
                this.baglanti.Close();
                SqlCommand command2 = new SqlCommand("SELECT DISTINCT(Şehir) FROM IL_ILCE", this.baglanti);
                this.comboBox2.Items.Clear();
                if (this.baglanti.State == ConnectionState.Closed)
                {
                    this.baglanti.Open();
                }
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    this.comboBox2.Items.Add(reader2[0].ToString());
                }
                this.baglanti.Close();
            }
            catch (Exception)
            {
                this.label12.Text = "Veritabanına Baglantınızı Kontrol Edin";
                this.label12.ForeColor = Color.Red;
                this.label12.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM POS_IRT ";
            if (this.baglanti.State == ConnectionState.Closed)
            {
                this.baglanti.Open();
            }
            SqlCommand selectCommand = new SqlCommand(cmdText, this.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView6.DataSource = dataTable;
            dataTable.Clear();
            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM POS_IRT WHERE AD LIKE'" + this.textBox1.Text + "%'", this.baglanti);
            SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM POS_IRT WHERE SOYAD LIKE'" + this.textBox1.Text + "%'", this.baglanti);
            adapter2.Fill(dataTable);
            adapter3.Fill(dataTable);
            this.dataGridView6.DataSource = dataTable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.label8.Text = now.ToLongTimeString();
            this.label9.Text = now.ToShortDateString();
        }
    }
}

