
namespace Discord_Utilities
{
    partial class form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton8 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton7 = new MetroFramework.Controls.MetroRadioButton();
            this.cont = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.spam = new MetroFramework.Controls.MetroButton();
            this.stop = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton9 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.details = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.slate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lik = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.smik = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.apid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.delab = new MetroFramework.Controls.MetroLabel();
            this.stlab = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.sit = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Discord Utilities";
            this.notifyIcon1.BalloonTipTitle = "Minimized to system tray double click to icon to open program.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Discord Utilities";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButton4);
            this.metroTabPage3.Controls.Add(this.pictureBox2);
            this.metroTabPage3.Controls.Add(this.metroLabel26);
            this.metroTabPage3.Controls.Add(this.metroLabel25);
            this.metroTabPage3.Controls.Add(this.metroLabel24);
            this.metroTabPage3.Controls.Add(this.metroLabel23);
            this.metroTabPage3.Controls.Add(this.metroLabel22);
            this.metroTabPage3.Controls.Add(this.metroLabel21);
            this.metroTabPage3.Controls.Add(this.metroLabel20);
            this.metroTabPage3.Controls.Add(this.metroLabel19);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(691, 421);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(216, 12);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(223, 25);
            this.metroLabel19.TabIndex = 2;
            this.metroLabel19.Text = "ABOUT THIS SOFTWARE";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(212, 366);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(104, 25);
            this.metroLabel20.TabIndex = 3;
            this.metroLabel20.Text = "Developer:";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(322, 366);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(140, 25);
            this.metroLabel21.TabIndex = 4;
            this.metroLabel21.Text = "Mehmetali_345";
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.Location = new System.Drawing.Point(136, 391);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(411, 25);
            this.metroLabel22.TabIndex = 5;
            this.metroLabel22.Text = "This program is not affiliated with Discord INC.";
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel23.Location = new System.Drawing.Point(251, 37);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(162, 25);
            this.metroLabel23.TabIndex = 6;
            this.metroLabel23.Text = "3rdParty Libraries";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel23.Click += new System.EventHandler(this.metroLabel23_Click);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel24.Location = new System.Drawing.Point(216, 89);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(214, 19);
            this.metroLabel24.TabIndex = 7;
            this.metroLabel24.Text = "MetroModernUI - Dennis Magno";
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel25.Location = new System.Drawing.Point(251, 70);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(146, 19);
            this.metroLabel25.TabIndex = 8;
            this.metroLabel25.Text = "DiscordSharp - Lachee";
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel26.Location = new System.Drawing.Point(216, 108);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(246, 19);
            this.metroLabel26.TabIndex = 9;
            this.metroLabel26.Text = "Newtonsoft.Json - James Newton-King";
            this.metroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(600, 382);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 12;
            this.metroButton4.Text = "Website ->";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel18);
            this.metroTabPage2.Controls.Add(this.metroRadioButton9);
            this.metroTabPage2.Controls.Add(this.stop);
            this.metroTabPage2.Controls.Add(this.spam);
            this.metroTabPage2.Controls.Add(this.metroLabel17);
            this.metroTabPage2.Controls.Add(this.cont);
            this.metroTabPage2.Controls.Add(this.metroRadioButton7);
            this.metroTabPage2.Controls.Add(this.metroRadioButton8);
            this.metroTabPage2.Controls.Add(this.metroRadioButton5);
            this.metroTabPage2.Controls.Add(this.metroRadioButton6);
            this.metroTabPage2.Controls.Add(this.metroRadioButton3);
            this.metroTabPage2.Controls.Add(this.metroRadioButton4);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroRadioButton2);
            this.metroTabPage2.Controls.Add(this.metroRadioButton1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(691, 421);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Spammer";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(23, 76);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(45, 15);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.Text = "1ms";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(23, 101);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(51, 15);
            this.metroRadioButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton2.TabIndex = 3;
            this.metroRadioButton2.Text = "10ms";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(42, 44);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(93, 19);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "Spam Speed";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(23, 126);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(51, 15);
            this.metroRadioButton4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton4.TabIndex = 5;
            this.metroRadioButton4.Text = "50ms";
            this.metroRadioButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton4.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(23, 151);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(51, 15);
            this.metroRadioButton3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton3.TabIndex = 6;
            this.metroRadioButton3.Text = "70ms";
            this.metroRadioButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(23, 175);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(57, 15);
            this.metroRadioButton6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton6.TabIndex = 7;
            this.metroRadioButton6.Text = "100ms";
            this.metroRadioButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton6.UseSelectable = true;
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(23, 200);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(57, 15);
            this.metroRadioButton5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton5.TabIndex = 8;
            this.metroRadioButton5.Text = "200ms";
            this.metroRadioButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton5.UseSelectable = true;
            // 
            // metroRadioButton8
            // 
            this.metroRadioButton8.AutoSize = true;
            this.metroRadioButton8.Location = new System.Drawing.Point(23, 224);
            this.metroRadioButton8.Name = "metroRadioButton8";
            this.metroRadioButton8.Size = new System.Drawing.Size(57, 15);
            this.metroRadioButton8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton8.TabIndex = 9;
            this.metroRadioButton8.Text = "500ms";
            this.metroRadioButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton8.UseSelectable = true;
            this.metroRadioButton8.CheckedChanged += new System.EventHandler(this.metroRadioButton8_CheckedChanged);
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(23, 249);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(57, 15);
            this.metroRadioButton7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton7.TabIndex = 10;
            this.metroRadioButton7.Text = "800ms";
            this.metroRadioButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton7.UseSelectable = true;
            // 
            // cont
            // 
            // 
            // 
            // 
            this.cont.CustomButton.Image = null;
            this.cont.CustomButton.Location = new System.Drawing.Point(19, 2);
            this.cont.CustomButton.Name = "";
            this.cont.CustomButton.Size = new System.Drawing.Size(237, 237);
            this.cont.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cont.CustomButton.TabIndex = 1;
            this.cont.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cont.CustomButton.UseSelectable = true;
            this.cont.CustomButton.Visible = false;
            this.cont.Lines = new string[] {
        "DiscordUtilities"};
            this.cont.Location = new System.Drawing.Point(424, 66);
            this.cont.MaxLength = 32767;
            this.cont.Multiline = true;
            this.cont.Name = "cont";
            this.cont.PasswordChar = '\0';
            this.cont.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cont.SelectedText = "";
            this.cont.SelectionLength = 0;
            this.cont.SelectionStart = 0;
            this.cont.ShortcutsEnabled = true;
            this.cont.Size = new System.Drawing.Size(259, 242);
            this.cont.TabIndex = 15;
            this.cont.Text = "DiscordUtilities";
            this.cont.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cont.UseSelectable = true;
            this.cont.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cont.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(512, 44);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(61, 19);
            this.metroLabel17.TabIndex = 16;
            this.metroLabel17.Text = "Content";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // spam
            // 
            this.spam.Location = new System.Drawing.Point(594, 371);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(89, 42);
            this.spam.TabIndex = 20;
            this.spam.Text = "Spam!";
            this.spam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.spam.UseSelectable = true;
            this.spam.Click += new System.EventHandler(this.spam_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(499, 371);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(89, 42);
            this.stop.TabIndex = 21;
            this.stop.Text = "Stop it!";
            this.stop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stop.UseSelectable = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // metroRadioButton9
            // 
            this.metroRadioButton9.AutoSize = true;
            this.metroRadioButton9.Location = new System.Drawing.Point(23, 274);
            this.metroRadioButton9.Name = "metroRadioButton9";
            this.metroRadioButton9.Size = new System.Drawing.Size(63, 15);
            this.metroRadioButton9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroRadioButton9.TabIndex = 22;
            this.metroRadioButton9.Text = "1000ms";
            this.metroRadioButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton9.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(23, 394);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(157, 19);
            this.metroLabel18.TabIndex = 23;
            this.metroLabel18.Text = "1ms is Fucking Computer";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTabPage1.Controls.Add(this.sit);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.lit);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.apid);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.smik);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.lik);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.slate);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.details);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(691, 421);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Discord RPC";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Details * :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // details
            // 
            // 
            // 
            // 
            this.details.CustomButton.Image = null;
            this.details.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.details.CustomButton.Name = "";
            this.details.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.details.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.details.CustomButton.TabIndex = 1;
            this.details.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.details.CustomButton.UseSelectable = true;
            this.details.CustomButton.Visible = false;
            this.details.Lines = new string[0];
            this.details.Location = new System.Drawing.Point(78, 45);
            this.details.MaxLength = 32767;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.details.SelectedText = "";
            this.details.SelectionLength = 0;
            this.details.SelectionStart = 0;
            this.details.ShortcutsEnabled = true;
            this.details.Size = new System.Drawing.Size(188, 23);
            this.details.TabIndex = 3;
            this.details.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.details.UseSelectable = true;
            this.details.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.details.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "State";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // slate
            // 
            // 
            // 
            // 
            this.slate.CustomButton.Image = null;
            this.slate.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.slate.CustomButton.Name = "";
            this.slate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.slate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.slate.CustomButton.TabIndex = 1;
            this.slate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.slate.CustomButton.UseSelectable = true;
            this.slate.CustomButton.Visible = false;
            this.slate.Lines = new string[0];
            this.slate.Location = new System.Drawing.Point(78, 94);
            this.slate.MaxLength = 32767;
            this.slate.Name = "slate";
            this.slate.PasswordChar = '\0';
            this.slate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.slate.SelectedText = "";
            this.slate.SelectionLength = 0;
            this.slate.SelectionStart = 0;
            this.slate.ShortcutsEnabled = true;
            this.slate.Size = new System.Drawing.Size(188, 23);
            this.slate.TabIndex = 5;
            this.slate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.slate.UseSelectable = true;
            this.slate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.slate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Large Image Key:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lik
            // 
            // 
            // 
            // 
            this.lik.CustomButton.Image = null;
            this.lik.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.lik.CustomButton.Name = "";
            this.lik.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lik.CustomButton.TabIndex = 1;
            this.lik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lik.CustomButton.UseSelectable = true;
            this.lik.CustomButton.Visible = false;
            this.lik.Lines = new string[0];
            this.lik.Location = new System.Drawing.Point(124, 178);
            this.lik.MaxLength = 32767;
            this.lik.Name = "lik";
            this.lik.PasswordChar = '\0';
            this.lik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lik.SelectedText = "";
            this.lik.SelectionLength = 0;
            this.lik.SelectionStart = 0;
            this.lik.ShortcutsEnabled = true;
            this.lik.Size = new System.Drawing.Size(188, 23);
            this.lik.TabIndex = 7;
            this.lik.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lik.UseSelectable = true;
            this.lik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Small Image Key:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // smik
            // 
            // 
            // 
            // 
            this.smik.CustomButton.Image = null;
            this.smik.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.smik.CustomButton.Name = "";
            this.smik.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.smik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.smik.CustomButton.TabIndex = 1;
            this.smik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.smik.CustomButton.UseSelectable = true;
            this.smik.CustomButton.Visible = false;
            this.smik.Lines = new string[0];
            this.smik.Location = new System.Drawing.Point(124, 213);
            this.smik.MaxLength = 32767;
            this.smik.Name = "smik";
            this.smik.PasswordChar = '\0';
            this.smik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.smik.SelectedText = "";
            this.smik.SelectionLength = 0;
            this.smik.SelectionStart = 0;
            this.smik.ShortcutsEnabled = true;
            this.smik.Size = new System.Drawing.Size(188, 23);
            this.smik.TabIndex = 9;
            this.smik.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.smik.UseSelectable = true;
            this.smik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.smik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 329);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(101, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Application ID *";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // apid
            // 
            // 
            // 
            // 
            this.apid.CustomButton.Image = null;
            this.apid.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.apid.CustomButton.Name = "";
            this.apid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.apid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.apid.CustomButton.TabIndex = 1;
            this.apid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.apid.CustomButton.UseSelectable = true;
            this.apid.CustomButton.Visible = false;
            this.apid.Lines = new string[0];
            this.apid.Location = new System.Drawing.Point(8, 351);
            this.apid.MaxLength = 32767;
            this.apid.Name = "apid";
            this.apid.PasswordChar = '\0';
            this.apid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apid.SelectedText = "";
            this.apid.SelectionLength = 0;
            this.apid.SelectionStart = 0;
            this.apid.ShortcutsEnabled = true;
            this.apid.Size = new System.Drawing.Size(188, 23);
            this.apid.TabIndex = 13;
            this.apid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apid.UseSelectable = true;
            this.apid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.apid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(322, 397);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(79, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "* = Needed";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(171, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Image Settings";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(430, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(253, 332);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(130)))), ((int)(((byte)(207)))));
            this.metroPanel2.Controls.Add(this.stlab);
            this.metroPanel2.Controls.Add(this.delab);
            this.metroPanel2.Controls.Add(this.metroLabel12);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 113);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(250, 131);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(3, 9);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(127, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "PLAYING A GAME";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(8, 31);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(76, 76);
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.SkyBlue;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(51, 51);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(25, 25);
            this.metroPanel4.TabIndex = 22;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.White;
            this.metroLabel12.Location = new System.Drawing.Point(85, 32);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(130, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Application Name";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // delab
            // 
            this.delab.AutoSize = true;
            this.delab.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.delab.ForeColor = System.Drawing.Color.White;
            this.delab.Location = new System.Drawing.Point(85, 53);
            this.delab.Name = "delab";
            this.delab.Size = new System.Drawing.Size(50, 19);
            this.delab.TabIndex = 24;
            this.delab.Text = "Details";
            this.delab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delab.UseCustomBackColor = true;
            this.delab.UseCustomForeColor = true;
            // 
            // stlab
            // 
            this.stlab.AutoSize = true;
            this.stlab.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.stlab.ForeColor = System.Drawing.Color.White;
            this.stlab.Location = new System.Drawing.Point(85, 72);
            this.stlab.Name = "stlab";
            this.stlab.Size = new System.Drawing.Size(40, 19);
            this.stlab.TabIndex = 25;
            this.stlab.Text = "State";
            this.stlab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stlab.UseCustomBackColor = true;
            this.stlab.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(59, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(144, 19);
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "Anakin Skywalker#6419";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(3, 247);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "NOTE";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel11.Location = new System.Drawing.Point(3, 269);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(164, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Developer of this software.";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(599, 376);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 42);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Fire!";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(502, 376);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(89, 42);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "Update";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.Color.White;
            this.metroLabel13.Location = new System.Drawing.Point(520, 6);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(68, 19);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "PREVIEW";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(407, 376);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 42);
            this.metroButton3.TabIndex = 21;
            this.metroButton3.Text = "Get Preview";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(8, 249);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(114, 19);
            this.metroLabel15.TabIndex = 22;
            this.metroLabel15.Text = "Large Image Text:";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lit
            // 
            // 
            // 
            // 
            this.lit.CustomButton.Image = null;
            this.lit.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.lit.CustomButton.Name = "";
            this.lit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lit.CustomButton.TabIndex = 1;
            this.lit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lit.CustomButton.UseSelectable = true;
            this.lit.CustomButton.Visible = false;
            this.lit.Lines = new string[0];
            this.lit.Location = new System.Drawing.Point(124, 249);
            this.lit.MaxLength = 32767;
            this.lit.Name = "lit";
            this.lit.PasswordChar = '\0';
            this.lit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lit.SelectedText = "";
            this.lit.SelectionLength = 0;
            this.lit.SelectionStart = 0;
            this.lit.ShortcutsEnabled = true;
            this.lit.Size = new System.Drawing.Size(188, 23);
            this.lit.TabIndex = 23;
            this.lit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lit.UseSelectable = true;
            this.lit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(9, 282);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(113, 19);
            this.metroLabel14.TabIndex = 24;
            this.metroLabel14.Text = "Small Image Text:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sit
            // 
            // 
            // 
            // 
            this.sit.CustomButton.Image = null;
            this.sit.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.sit.CustomButton.Name = "";
            this.sit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sit.CustomButton.TabIndex = 1;
            this.sit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sit.CustomButton.UseSelectable = true;
            this.sit.CustomButton.Visible = false;
            this.sit.Lines = new string[0];
            this.sit.Location = new System.Drawing.Point(124, 282);
            this.sit.MaxLength = 32767;
            this.sit.Name = "sit";
            this.sit.PasswordChar = '\0';
            this.sit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sit.SelectedText = "";
            this.sit.SelectionLength = 0;
            this.sit.SelectionStart = 0;
            this.sit.ShortcutsEnabled = true;
            this.sit.Size = new System.Drawing.Size(188, 23);
            this.sit.TabIndex = 25;
            this.sit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sit.UseSelectable = true;
            this.sit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(699, 463);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(699, 463);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Utilities";
            this.Resize += new System.EventHandler(this.form1_Resize);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton9;
        private MetroFramework.Controls.MetroButton stop;
        private MetroFramework.Controls.MetroButton spam;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox cont;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton8;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox sit;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox lit;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel stlab;
        private MetroFramework.Controls.MetroLabel delab;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox apid;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox smik;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox lik;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox slate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox details;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}

