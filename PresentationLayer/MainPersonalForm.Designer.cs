namespace PresentationLayer
{
    partial class MainPersonalForm
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
            this.tabControlMainAdmin = new System.Windows.Forms.TabControl();
            this.tabPageCreateActivity = new System.Windows.Forms.TabPage();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.SkapaAktivitetKnapp = new System.Windows.Forms.Button();
            this.SluttidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.StarttidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PlatsTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KontaktPersonTxtBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnsvarigPersonTxtBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitelAktivitetTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEditActivity = new System.Windows.Forms.TabPage();
            this.BeskrivningÄndraTextBox = new System.Windows.Forms.RichTextBox();
            this.VäljAktivitetComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SlutdatumÄndraDateTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.StarttidDateTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.PlatsÄndraTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.KontaktpersonComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AnsvarigPersonComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ÄndraTitelTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageViewActivityAtendence = new System.Windows.Forms.TabPage();
            this.AnmäldaAlumnerDataGridView = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.VäljAktivitetSeAnmälancomboBox = new System.Windows.Forms.ComboBox();
            this.tabPageMakeEmailList = new System.Windows.Forms.TabPage();
            this.TaBortAlumnBtn = new System.Windows.Forms.Button();
            this.GamlaListorComboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.NamnUtskicksListaTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.flyttaAlumner = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.valdaAlumnerListBox = new System.Windows.Forms.ListBox();
            this.AktivitetComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.alumnCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBoxFilterAlumns = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCreateAlumnCSV = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageGamlaUtskicksListor = new System.Windows.Forms.TabPage();
            this.SkapaCSVFrånGammalListaBtn = new System.Windows.Forms.Button();
            this.utskickslistaAlumner = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.VäljGammalUtskicksListacomboBox = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.LaddaGamlaAlumnerFrånListabtn = new System.Windows.Forms.Button();
            this.tabControlMainAdmin.SuspendLayout();
            this.tabPageCreateActivity.SuspendLayout();
            this.tabPageEditActivity.SuspendLayout();
            this.tabPageViewActivityAtendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnmäldaAlumnerDataGridView)).BeginInit();
            this.tabPageMakeEmailList.SuspendLayout();
            this.tabPageGamlaUtskicksListor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utskickslistaAlumner)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMainAdmin
            // 
            this.tabControlMainAdmin.AllowDrop = true;
            this.tabControlMainAdmin.Controls.Add(this.tabPageCreateActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageEditActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageViewActivityAtendence);
            this.tabControlMainAdmin.Controls.Add(this.tabPageMakeEmailList);
            this.tabControlMainAdmin.Controls.Add(this.tabPageGamlaUtskicksListor);
            this.tabControlMainAdmin.Location = new System.Drawing.Point(11, 12);
            this.tabControlMainAdmin.Multiline = true;
            this.tabControlMainAdmin.Name = "tabControlMainAdmin";
            this.tabControlMainAdmin.SelectedIndex = 0;
            this.tabControlMainAdmin.Size = new System.Drawing.Size(519, 329);
            this.tabControlMainAdmin.TabIndex = 0;
            this.tabControlMainAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlMainAdmin_SelectedIndexChanged);
            // 
            // tabPageCreateActivity
            // 
            this.tabPageCreateActivity.Controls.Add(this.BeskrivningTextBox);
            this.tabPageCreateActivity.Controls.Add(this.SkapaAktivitetKnapp);
            this.tabPageCreateActivity.Controls.Add(this.SluttidDateTimePicker);
            this.tabPageCreateActivity.Controls.Add(this.label7);
            this.tabPageCreateActivity.Controls.Add(this.StarttidDateTimePicker);
            this.tabPageCreateActivity.Controls.Add(this.label6);
            this.tabPageCreateActivity.Controls.Add(this.PlatsTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label5);
            this.tabPageCreateActivity.Controls.Add(this.KontaktPersonTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label4);
            this.tabPageCreateActivity.Controls.Add(this.AnsvarigPersonTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label3);
            this.tabPageCreateActivity.Controls.Add(this.TitelAktivitetTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label2);
            this.tabPageCreateActivity.Controls.Add(this.label1);
            this.tabPageCreateActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateActivity.Name = "tabPageCreateActivity";
            this.tabPageCreateActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateActivity.Size = new System.Drawing.Size(511, 303);
            this.tabPageCreateActivity.TabIndex = 0;
            this.tabPageCreateActivity.Text = "Skapa aktivitet";
            this.tabPageCreateActivity.UseVisualStyleBackColor = true;
            this.tabPageCreateActivity.Click += new System.EventHandler(this.tabPageCreateActivity_Click);
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(250, 29);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(238, 175);
            this.BeskrivningTextBox.TabIndex = 15;
            this.BeskrivningTextBox.Text = "";
            // 
            // SkapaAktivitetKnapp
            // 
            this.SkapaAktivitetKnapp.Location = new System.Drawing.Point(250, 223);
            this.SkapaAktivitetKnapp.Name = "SkapaAktivitetKnapp";
            this.SkapaAktivitetKnapp.Size = new System.Drawing.Size(238, 23);
            this.SkapaAktivitetKnapp.TabIndex = 14;
            this.SkapaAktivitetKnapp.Text = "Skapa aktivitet";
            this.SkapaAktivitetKnapp.UseVisualStyleBackColor = true;
            this.SkapaAktivitetKnapp.Click += new System.EventHandler(this.BtnCreateActivity_Click);
            // 
            // SluttidDateTimePicker
            // 
            this.SluttidDateTimePicker.Location = new System.Drawing.Point(10, 223);
            this.SluttidDateTimePicker.Name = "SluttidDateTimePicker";
            this.SluttidDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.SluttidDateTimePicker.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datum och sluttid";
            // 
            // StarttidDateTimePicker
            // 
            this.StarttidDateTimePicker.Location = new System.Drawing.Point(10, 184);
            this.StarttidDateTimePicker.Name = "StarttidDateTimePicker";
            this.StarttidDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.StarttidDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum och starttid";
            // 
            // PlatsTxtBox
            // 
            this.PlatsTxtBox.Location = new System.Drawing.Point(10, 144);
            this.PlatsTxtBox.Name = "PlatsTxtBox";
            this.PlatsTxtBox.Size = new System.Drawing.Size(208, 20);
            this.PlatsTxtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plats";
            // 
            // KontaktPersonTxtBox
            // 
            this.KontaktPersonTxtBox.FormattingEnabled = true;
            this.KontaktPersonTxtBox.Items.AddRange(new object[] {
            "Huu Boii"});
            this.KontaktPersonTxtBox.Location = new System.Drawing.Point(10, 104);
            this.KontaktPersonTxtBox.Name = "KontaktPersonTxtBox";
            this.KontaktPersonTxtBox.Size = new System.Drawing.Size(208, 21);
            this.KontaktPersonTxtBox.TabIndex = 6;
            this.KontaktPersonTxtBox.SelectedIndexChanged += new System.EventHandler(this.KontaktPersonTxtBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kontaktperson";
            // 
            // AnsvarigPersonTxtBox
            // 
            this.AnsvarigPersonTxtBox.FormattingEnabled = true;
            this.AnsvarigPersonTxtBox.Items.AddRange(new object[] {
            "Göran Nemt"});
            this.AnsvarigPersonTxtBox.Location = new System.Drawing.Point(10, 64);
            this.AnsvarigPersonTxtBox.Name = "AnsvarigPersonTxtBox";
            this.AnsvarigPersonTxtBox.Size = new System.Drawing.Size(208, 21);
            this.AnsvarigPersonTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ansvarig person";
            // 
            // TitelAktivitetTxtBox
            // 
            this.TitelAktivitetTxtBox.Location = new System.Drawing.Point(10, 24);
            this.TitelAktivitetTxtBox.Name = "TitelAktivitetTxtBox";
            this.TitelAktivitetTxtBox.Size = new System.Drawing.Size(208, 20);
            this.TitelAktivitetTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beskrivning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // tabPageEditActivity
            // 
            this.tabPageEditActivity.Controls.Add(this.BeskrivningÄndraTextBox);
            this.tabPageEditActivity.Controls.Add(this.VäljAktivitetComboBox);
            this.tabPageEditActivity.Controls.Add(this.label15);
            this.tabPageEditActivity.Controls.Add(this.btnSaveChanges);
            this.tabPageEditActivity.Controls.Add(this.label14);
            this.tabPageEditActivity.Controls.Add(this.SlutdatumÄndraDateTime);
            this.tabPageEditActivity.Controls.Add(this.label13);
            this.tabPageEditActivity.Controls.Add(this.StarttidDateTime);
            this.tabPageEditActivity.Controls.Add(this.label12);
            this.tabPageEditActivity.Controls.Add(this.PlatsÄndraTxtBox);
            this.tabPageEditActivity.Controls.Add(this.label11);
            this.tabPageEditActivity.Controls.Add(this.KontaktpersonComboBox);
            this.tabPageEditActivity.Controls.Add(this.label10);
            this.tabPageEditActivity.Controls.Add(this.AnsvarigPersonComboBox);
            this.tabPageEditActivity.Controls.Add(this.label9);
            this.tabPageEditActivity.Controls.Add(this.ÄndraTitelTxtBox);
            this.tabPageEditActivity.Controls.Add(this.label8);
            this.tabPageEditActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditActivity.Name = "tabPageEditActivity";
            this.tabPageEditActivity.Size = new System.Drawing.Size(511, 303);
            this.tabPageEditActivity.TabIndex = 2;
            this.tabPageEditActivity.Text = "Redigera aktivitet";
            this.tabPageEditActivity.UseVisualStyleBackColor = true;
            // 
            // BeskrivningÄndraTextBox
            // 
            this.BeskrivningÄndraTextBox.Location = new System.Drawing.Point(250, 71);
            this.BeskrivningÄndraTextBox.Name = "BeskrivningÄndraTextBox";
            this.BeskrivningÄndraTextBox.Size = new System.Drawing.Size(242, 175);
            this.BeskrivningÄndraTextBox.TabIndex = 17;
            this.BeskrivningÄndraTextBox.Text = "";
            // 
            // VäljAktivitetComboBox
            // 
            this.VäljAktivitetComboBox.FormattingEnabled = true;
            this.VäljAktivitetComboBox.Location = new System.Drawing.Point(17, 25);
            this.VäljAktivitetComboBox.Name = "VäljAktivitetComboBox";
            this.VäljAktivitetComboBox.Size = new System.Drawing.Size(475, 21);
            this.VäljAktivitetComboBox.TabIndex = 16;
            this.VäljAktivitetComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoosActivity_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Välj aktivitet att redigera:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(250, 265);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(242, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Spara ändringar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Beskrivning";
            // 
            // SlutdatumÄndraDateTime
            // 
            this.SlutdatumÄndraDateTime.Location = new System.Drawing.Point(17, 265);
            this.SlutdatumÄndraDateTime.Name = "SlutdatumÄndraDateTime";
            this.SlutdatumÄndraDateTime.Size = new System.Drawing.Size(212, 20);
            this.SlutdatumÄndraDateTime.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Datum och sluttid";
            // 
            // StarttidDateTime
            // 
            this.StarttidDateTime.Location = new System.Drawing.Point(17, 226);
            this.StarttidDateTime.Name = "StarttidDateTime";
            this.StarttidDateTime.Size = new System.Drawing.Size(212, 20);
            this.StarttidDateTime.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Datum och starttid";
            // 
            // PlatsÄndraTxtBox
            // 
            this.PlatsÄndraTxtBox.Location = new System.Drawing.Point(17, 186);
            this.PlatsÄndraTxtBox.Name = "PlatsÄndraTxtBox";
            this.PlatsÄndraTxtBox.Size = new System.Drawing.Size(212, 20);
            this.PlatsÄndraTxtBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Plats";
            // 
            // KontaktpersonComboBox
            // 
            this.KontaktpersonComboBox.FormattingEnabled = true;
            this.KontaktpersonComboBox.Location = new System.Drawing.Point(17, 146);
            this.KontaktpersonComboBox.Name = "KontaktpersonComboBox";
            this.KontaktpersonComboBox.Size = new System.Drawing.Size(212, 21);
            this.KontaktpersonComboBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kontaktperson";
            // 
            // AnsvarigPersonComboBox
            // 
            this.AnsvarigPersonComboBox.FormattingEnabled = true;
            this.AnsvarigPersonComboBox.Location = new System.Drawing.Point(17, 106);
            this.AnsvarigPersonComboBox.Name = "AnsvarigPersonComboBox";
            this.AnsvarigPersonComboBox.Size = new System.Drawing.Size(212, 21);
            this.AnsvarigPersonComboBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ansvarig person";
            // 
            // ÄndraTitelTxtBox
            // 
            this.ÄndraTitelTxtBox.Location = new System.Drawing.Point(17, 66);
            this.ÄndraTitelTxtBox.Name = "ÄndraTitelTxtBox";
            this.ÄndraTitelTxtBox.Size = new System.Drawing.Size(212, 20);
            this.ÄndraTitelTxtBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Titel";
            // 
            // tabPageViewActivityAtendence
            // 
            this.tabPageViewActivityAtendence.Controls.Add(this.AnmäldaAlumnerDataGridView);
            this.tabPageViewActivityAtendence.Controls.Add(this.label24);
            this.tabPageViewActivityAtendence.Controls.Add(this.label23);
            this.tabPageViewActivityAtendence.Controls.Add(this.VäljAktivitetSeAnmälancomboBox);
            this.tabPageViewActivityAtendence.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewActivityAtendence.Name = "tabPageViewActivityAtendence";
            this.tabPageViewActivityAtendence.Size = new System.Drawing.Size(511, 303);
            this.tabPageViewActivityAtendence.TabIndex = 5;
            this.tabPageViewActivityAtendence.Text = "Se anmälningar";
            this.tabPageViewActivityAtendence.UseVisualStyleBackColor = true;
            // 
            // AnmäldaAlumnerDataGridView
            // 
            this.AnmäldaAlumnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnmäldaAlumnerDataGridView.Location = new System.Drawing.Point(12, 83);
            this.AnmäldaAlumnerDataGridView.Name = "AnmäldaAlumnerDataGridView";
            this.AnmäldaAlumnerDataGridView.Size = new System.Drawing.Size(484, 204);
            this.AnmäldaAlumnerDataGridView.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Anmälda alumner";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Välj aktivitet";
            // 
            // VäljAktivitetSeAnmälancomboBox
            // 
            this.VäljAktivitetSeAnmälancomboBox.FormattingEnabled = true;
            this.VäljAktivitetSeAnmälancomboBox.Location = new System.Drawing.Point(12, 31);
            this.VäljAktivitetSeAnmälancomboBox.Name = "VäljAktivitetSeAnmälancomboBox";
            this.VäljAktivitetSeAnmälancomboBox.Size = new System.Drawing.Size(197, 21);
            this.VäljAktivitetSeAnmälancomboBox.TabIndex = 0;
            this.VäljAktivitetSeAnmälancomboBox.SelectedIndexChanged += new System.EventHandler(this.VäljAktivitetSeAnmälancomboBox_SelectedIndexChanged);
            // 
            // tabPageMakeEmailList
            // 
            this.tabPageMakeEmailList.Controls.Add(this.LaddaGamlaAlumnerFrånListabtn);
            this.tabPageMakeEmailList.Controls.Add(this.TaBortAlumnBtn);
            this.tabPageMakeEmailList.Controls.Add(this.GamlaListorComboBox);
            this.tabPageMakeEmailList.Controls.Add(this.label22);
            this.tabPageMakeEmailList.Controls.Add(this.label20);
            this.tabPageMakeEmailList.Controls.Add(this.NamnUtskicksListaTextBox);
            this.tabPageMakeEmailList.Controls.Add(this.flyttaAlumner);
            this.tabPageMakeEmailList.Controls.Add(this.label19);
            this.tabPageMakeEmailList.Controls.Add(this.valdaAlumnerListBox);
            this.tabPageMakeEmailList.Controls.Add(this.AktivitetComboBox);
            this.tabPageMakeEmailList.Controls.Add(this.label18);
            this.tabPageMakeEmailList.Controls.Add(this.alumnCheckedListBox);
            this.tabPageMakeEmailList.Controls.Add(this.comboBoxFilterAlumns);
            this.tabPageMakeEmailList.Controls.Add(this.label17);
            this.tabPageMakeEmailList.Controls.Add(this.btnCreateAlumnCSV);
            this.tabPageMakeEmailList.Controls.Add(this.label16);
            this.tabPageMakeEmailList.Location = new System.Drawing.Point(4, 22);
            this.tabPageMakeEmailList.Name = "tabPageMakeEmailList";
            this.tabPageMakeEmailList.Size = new System.Drawing.Size(511, 303);
            this.tabPageMakeEmailList.TabIndex = 3;
            this.tabPageMakeEmailList.Text = "Skapa utskickslista";
            this.tabPageMakeEmailList.UseVisualStyleBackColor = true;
            this.tabPageMakeEmailList.Click += new System.EventHandler(this.tabPageMakeEmailList_Click);
            // 
            // TaBortAlumnBtn
            // 
            this.TaBortAlumnBtn.Location = new System.Drawing.Point(173, 196);
            this.TaBortAlumnBtn.Name = "TaBortAlumnBtn";
            this.TaBortAlumnBtn.Size = new System.Drawing.Size(75, 23);
            this.TaBortAlumnBtn.TabIndex = 20;
            this.TaBortAlumnBtn.Text = "Ta bort";
            this.TaBortAlumnBtn.UseVisualStyleBackColor = true;
            this.TaBortAlumnBtn.Click += new System.EventHandler(this.TaBortAlumnBtn_Click);
            // 
            // GamlaListorComboBox
            // 
            this.GamlaListorComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GamlaListorComboBox.FormattingEnabled = true;
            this.GamlaListorComboBox.Items.AddRange(new object[] {
            ""});
            this.GamlaListorComboBox.Location = new System.Drawing.Point(254, 21);
            this.GamlaListorComboBox.Name = "GamlaListorComboBox";
            this.GamlaListorComboBox.Size = new System.Drawing.Size(145, 21);
            this.GamlaListorComboBox.TabIndex = 19;
            this.GamlaListorComboBox.Text = "Välj gammal lista";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Namnge utskickslista";
            // 
            // NamnUtskicksListaTextBox
            // 
            this.NamnUtskicksListaTextBox.Location = new System.Drawing.Point(22, 22);
            this.NamnUtskicksListaTextBox.Name = "NamnUtskicksListaTextBox";
            this.NamnUtskicksListaTextBox.Size = new System.Drawing.Size(142, 20);
            this.NamnUtskicksListaTextBox.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Filtrera på program";
            // 
            // flyttaAlumner
            // 
            this.flyttaAlumner.Location = new System.Drawing.Point(173, 167);
            this.flyttaAlumner.Name = "flyttaAlumner";
            this.flyttaAlumner.Size = new System.Drawing.Size(75, 23);
            this.flyttaAlumner.TabIndex = 13;
            this.flyttaAlumner.Text = "Välj ";
            this.flyttaAlumner.UseVisualStyleBackColor = true;
            this.flyttaAlumner.Click += new System.EventHandler(this.flyttaAlumner_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(253, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Valda alumner";
            // 
            // valdaAlumnerListBox
            // 
            this.valdaAlumnerListBox.FormattingEnabled = true;
            this.valdaAlumnerListBox.Location = new System.Drawing.Point(254, 106);
            this.valdaAlumnerListBox.Name = "valdaAlumnerListBox";
            this.valdaAlumnerListBox.Size = new System.Drawing.Size(142, 173);
            this.valdaAlumnerListBox.TabIndex = 11;
            // 
            // AktivitetComboBox
            // 
            this.AktivitetComboBox.FormattingEnabled = true;
            this.AktivitetComboBox.Location = new System.Drawing.Point(254, 63);
            this.AktivitetComboBox.Name = "AktivitetComboBox";
            this.AktivitetComboBox.Size = new System.Drawing.Size(142, 21);
            this.AktivitetComboBox.TabIndex = 10;
            this.AktivitetComboBox.SelectedIndexChanged += new System.EventHandler(this.AktivitetComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(251, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Välj aktivitet";
            // 
            // alumnCheckedListBox
            // 
            this.alumnCheckedListBox.FormattingEnabled = true;
            this.alumnCheckedListBox.Location = new System.Drawing.Point(22, 110);
            this.alumnCheckedListBox.Name = "alumnCheckedListBox";
            this.alumnCheckedListBox.Size = new System.Drawing.Size(145, 169);
            this.alumnCheckedListBox.TabIndex = 5;
            this.alumnCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.AlumnCheckedListBox_SelectedIndexChanged);
            // 
            // comboBoxFilterAlumns
            // 
            this.comboBoxFilterAlumns.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBoxFilterAlumns.FormattingEnabled = true;
            this.comboBoxFilterAlumns.Items.AddRange(new object[] {
            ""});
            this.comboBoxFilterAlumns.Location = new System.Drawing.Point(22, 66);
            this.comboBoxFilterAlumns.Name = "comboBoxFilterAlumns";
            this.comboBoxFilterAlumns.Size = new System.Drawing.Size(145, 21);
            this.comboBoxFilterAlumns.TabIndex = 4;
            this.comboBoxFilterAlumns.Text = "Välj program";
            this.comboBoxFilterAlumns.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterAlumns_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(251, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Utgå från gammal lista";
            // 
            // btnCreateAlumnCSV
            // 
            this.btnCreateAlumnCSV.Location = new System.Drawing.Point(406, 151);
            this.btnCreateAlumnCSV.Name = "btnCreateAlumnCSV";
            this.btnCreateAlumnCSV.Size = new System.Drawing.Size(92, 79);
            this.btnCreateAlumnCSV.TabIndex = 2;
            this.btnCreateAlumnCSV.Text = "Skapa utskickslista och generera .CSV fil ";
            this.btnCreateAlumnCSV.UseVisualStyleBackColor = true;
            this.btnCreateAlumnCSV.Click += new System.EventHandler(this.btnCreateAlumnCSV_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Välj alumn";
            // 
            // tabPageGamlaUtskicksListor
            // 
            this.tabPageGamlaUtskicksListor.Controls.Add(this.SkapaCSVFrånGammalListaBtn);
            this.tabPageGamlaUtskicksListor.Controls.Add(this.utskickslistaAlumner);
            this.tabPageGamlaUtskicksListor.Controls.Add(this.label25);
            this.tabPageGamlaUtskicksListor.Controls.Add(this.label26);
            this.tabPageGamlaUtskicksListor.Controls.Add(this.VäljGammalUtskicksListacomboBox);
            this.tabPageGamlaUtskicksListor.Location = new System.Drawing.Point(4, 22);
            this.tabPageGamlaUtskicksListor.Name = "tabPageGamlaUtskicksListor";
            this.tabPageGamlaUtskicksListor.Size = new System.Drawing.Size(511, 303);
            this.tabPageGamlaUtskicksListor.TabIndex = 4;
            this.tabPageGamlaUtskicksListor.Text = "Gamla utskickslistor";
            this.tabPageGamlaUtskicksListor.UseVisualStyleBackColor = true;
            // 
            // SkapaCSVFrånGammalListaBtn
            // 
            this.SkapaCSVFrånGammalListaBtn.Location = new System.Drawing.Point(365, 264);
            this.SkapaCSVFrånGammalListaBtn.Name = "SkapaCSVFrånGammalListaBtn";
            this.SkapaCSVFrånGammalListaBtn.Size = new System.Drawing.Size(120, 23);
            this.SkapaCSVFrånGammalListaBtn.TabIndex = 9;
            this.SkapaCSVFrånGammalListaBtn.Text = "Generera .CSV-fil";
            this.SkapaCSVFrånGammalListaBtn.UseVisualStyleBackColor = true;
            // 
            // utskickslistaAlumner
            // 
            this.utskickslistaAlumner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utskickslistaAlumner.Location = new System.Drawing.Point(12, 94);
            this.utskickslistaAlumner.Name = "utskickslistaAlumner";
            this.utskickslistaAlumner.Size = new System.Drawing.Size(473, 164);
            this.utskickslistaAlumner.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Alumner i listan";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Välj utskickslista";
            // 
            // VäljGammalUtskicksListacomboBox
            // 
            this.VäljGammalUtskicksListacomboBox.FormattingEnabled = true;
            this.VäljGammalUtskicksListacomboBox.Location = new System.Drawing.Point(12, 31);
            this.VäljGammalUtskicksListacomboBox.Name = "VäljGammalUtskicksListacomboBox";
            this.VäljGammalUtskicksListacomboBox.Size = new System.Drawing.Size(197, 21);
            this.VäljGammalUtskicksListacomboBox.TabIndex = 4;
            this.VäljGammalUtskicksListacomboBox.SelectedIndexChanged += new System.EventHandler(this.VäljGammalUtskicksListacomboBox_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(456, 347);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logga ut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // LaddaGamlaAlumnerFrånListabtn
            // 
            this.LaddaGamlaAlumnerFrånListabtn.Location = new System.Drawing.Point(405, 20);
            this.LaddaGamlaAlumnerFrånListabtn.Name = "LaddaGamlaAlumnerFrånListabtn";
            this.LaddaGamlaAlumnerFrånListabtn.Size = new System.Drawing.Size(92, 23);
            this.LaddaGamlaAlumnerFrånListabtn.TabIndex = 21;
            this.LaddaGamlaAlumnerFrånListabtn.Text = "Hämta alumner";
            this.LaddaGamlaAlumnerFrånListabtn.UseVisualStyleBackColor = true;
            // 
            // MainPersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 382);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControlMainAdmin);
            this.Name = "MainPersonalForm";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.tabControlMainAdmin.ResumeLayout(false);
            this.tabPageCreateActivity.ResumeLayout(false);
            this.tabPageCreateActivity.PerformLayout();
            this.tabPageEditActivity.ResumeLayout(false);
            this.tabPageEditActivity.PerformLayout();
            this.tabPageViewActivityAtendence.ResumeLayout(false);
            this.tabPageViewActivityAtendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnmäldaAlumnerDataGridView)).EndInit();
            this.tabPageMakeEmailList.ResumeLayout(false);
            this.tabPageMakeEmailList.PerformLayout();
            this.tabPageGamlaUtskicksListor.ResumeLayout(false);
            this.tabPageGamlaUtskicksListor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utskickslistaAlumner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainAdmin;
        private System.Windows.Forms.TabPage tabPageCreateActivity;
        private System.Windows.Forms.TabPage tabPageEditActivity;
        private System.Windows.Forms.TabPage tabPageMakeEmailList;
        private System.Windows.Forms.Button SkapaAktivitetKnapp;
        private System.Windows.Forms.DateTimePicker SluttidDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker StarttidDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlatsTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox KontaktPersonTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AnsvarigPersonTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitelAktivitetTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker SlutdatumÄndraDateTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker StarttidDateTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PlatsÄndraTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox KontaktpersonComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox AnsvarigPersonComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ÄndraTitelTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox VäljAktivitetComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxFilterAlumns;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCreateAlumnCSV;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.CheckedListBox alumnCheckedListBox;
        private System.Windows.Forms.RichTextBox BeskrivningÄndraTextBox;
        private System.Windows.Forms.ListBox valdaAlumnerListBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button flyttaAlumner;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox AktivitetComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox NamnUtskicksListaTextBox;
        private System.Windows.Forms.TabPage tabPageViewActivityAtendence;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox VäljAktivitetSeAnmälancomboBox;
        private System.Windows.Forms.TabPage tabPageGamlaUtskicksListor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox VäljGammalUtskicksListacomboBox;
        private System.Windows.Forms.DataGridView AnmäldaAlumnerDataGridView;
        private System.Windows.Forms.Button SkapaCSVFrånGammalListaBtn;
        private System.Windows.Forms.DataGridView utskickslistaAlumner;
        private System.Windows.Forms.ComboBox GamlaListorComboBox;
        private System.Windows.Forms.Button TaBortAlumnBtn;
        private System.Windows.Forms.Button LaddaGamlaAlumnerFrånListabtn;
    }
}