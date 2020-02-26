namespace PresentationLayer
{
    partial class MainAlumnForm
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
            this.tabControlAlumn = new System.Windows.Forms.TabControl();
            this.tabPageUpcommingActivities = new System.Windows.Forms.TabPage();
            this.aktivitetsBeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.btnBookActivity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.informationsutskickListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBookedActivities = new System.Windows.Forms.TabPage();
            this.aktivitetsinformationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnCancelBookedActivity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bokadeAktiviteterListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAlumnFacts = new System.Windows.Forms.TabPage();
            this.taBortValtProgramBtn = new System.Windows.Forms.Button();
            this.Kompetenser = new System.Windows.Forms.Label();
            this.kompetenserListBox = new System.Windows.Forms.ListBox();
            this.nyUtbildningTxtBox = new System.Windows.Forms.TextBox();
            this.taBortvaldKompetensBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.programListBox = new System.Windows.Forms.ListBox();
            this.LäggTillArbetslivserfarenhetBtn = new System.Windows.Forms.Button();
            this.nyArbetslivserfarenhetTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.läggTillUtbildningBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageUserData = new System.Windows.Forms.TabPage();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.ändraEpostTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ändraEfternamnTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ändraFörnamnTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlAlumn.SuspendLayout();
            this.tabPageUpcommingActivities.SuspendLayout();
            this.tabPageBookedActivities.SuspendLayout();
            this.tabPageAlumnFacts.SuspendLayout();
            this.tabPageUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAlumn
            // 
            this.tabControlAlumn.Controls.Add(this.tabPageUpcommingActivities);
            this.tabControlAlumn.Controls.Add(this.tabPageBookedActivities);
            this.tabControlAlumn.Controls.Add(this.tabPageAlumnFacts);
            this.tabControlAlumn.Controls.Add(this.tabPageUserData);
            this.tabControlAlumn.Location = new System.Drawing.Point(12, 12);
            this.tabControlAlumn.Name = "tabControlAlumn";
            this.tabControlAlumn.SelectedIndex = 0;
            this.tabControlAlumn.Size = new System.Drawing.Size(579, 394);
            this.tabControlAlumn.TabIndex = 0;
            this.tabControlAlumn.SelectedIndexChanged += new System.EventHandler(this.tabControlAlumn_SelectedIndexChanged);
            // 
            // tabPageUpcommingActivities
            // 
            this.tabPageUpcommingActivities.Controls.Add(this.aktivitetsBeskrivningTextBox);
            this.tabPageUpcommingActivities.Controls.Add(this.btnBookActivity);
            this.tabPageUpcommingActivities.Controls.Add(this.label2);
            this.tabPageUpcommingActivities.Controls.Add(this.informationsutskickListBox);
            this.tabPageUpcommingActivities.Controls.Add(this.label1);
            this.tabPageUpcommingActivities.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpcommingActivities.Name = "tabPageUpcommingActivities";
            this.tabPageUpcommingActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpcommingActivities.Size = new System.Drawing.Size(571, 368);
            this.tabPageUpcommingActivities.TabIndex = 0;
            this.tabPageUpcommingActivities.Text = "Aktuella händelser";
            this.tabPageUpcommingActivities.UseVisualStyleBackColor = true;
            // 
            // aktivitetsBeskrivningTextBox
            // 
            this.aktivitetsBeskrivningTextBox.Location = new System.Drawing.Point(300, 36);
            this.aktivitetsBeskrivningTextBox.Name = "aktivitetsBeskrivningTextBox";
            this.aktivitetsBeskrivningTextBox.Size = new System.Drawing.Size(247, 290);
            this.aktivitetsBeskrivningTextBox.TabIndex = 5;
            this.aktivitetsBeskrivningTextBox.Text = "";
            // 
            // btnBookActivity
            // 
            this.btnBookActivity.Location = new System.Drawing.Point(416, 333);
            this.btnBookActivity.Name = "btnBookActivity";
            this.btnBookActivity.Size = new System.Drawing.Size(131, 23);
            this.btnBookActivity.TabIndex = 4;
            this.btnBookActivity.Text = "Boka vald aktivitet";
            this.btnBookActivity.UseVisualStyleBackColor = true;
            this.btnBookActivity.Click += new System.EventHandler(this.btnBookActivity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktivitetsinformation";
            // 
            // informationsutskickListBox
            // 
            this.informationsutskickListBox.FormattingEnabled = true;
            this.informationsutskickListBox.Location = new System.Drawing.Point(22, 36);
            this.informationsutskickListBox.Name = "informationsutskickListBox";
            this.informationsutskickListBox.Size = new System.Drawing.Size(251, 290);
            this.informationsutskickListBox.TabIndex = 1;
            this.informationsutskickListBox.SelectedIndexChanged += new System.EventHandler(this.informationsutskickListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kommande aktiviteter";
            // 
            // tabPageBookedActivities
            // 
            this.tabPageBookedActivities.Controls.Add(this.aktivitetsinformationRichTextBox);
            this.tabPageBookedActivities.Controls.Add(this.btnCancelBookedActivity);
            this.tabPageBookedActivities.Controls.Add(this.label4);
            this.tabPageBookedActivities.Controls.Add(this.bokadeAktiviteterListBox);
            this.tabPageBookedActivities.Controls.Add(this.label3);
            this.tabPageBookedActivities.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookedActivities.Name = "tabPageBookedActivities";
            this.tabPageBookedActivities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookedActivities.Size = new System.Drawing.Size(571, 368);
            this.tabPageBookedActivities.TabIndex = 1;
            this.tabPageBookedActivities.Text = "Bokade aktiviteter";
            this.tabPageBookedActivities.UseVisualStyleBackColor = true;
            // 
            // aktivitetsinformationRichTextBox
            // 
            this.aktivitetsinformationRichTextBox.Location = new System.Drawing.Point(288, 33);
            this.aktivitetsinformationRichTextBox.Name = "aktivitetsinformationRichTextBox";
            this.aktivitetsinformationRichTextBox.Size = new System.Drawing.Size(266, 290);
            this.aktivitetsinformationRichTextBox.TabIndex = 5;
            this.aktivitetsinformationRichTextBox.Text = "";
            // 
            // btnCancelBookedActivity
            // 
            this.btnCancelBookedActivity.Location = new System.Drawing.Point(415, 329);
            this.btnCancelBookedActivity.Name = "btnCancelBookedActivity";
            this.btnCancelBookedActivity.Size = new System.Drawing.Size(139, 23);
            this.btnCancelBookedActivity.TabIndex = 4;
            this.btnCancelBookedActivity.Text = "Avboka vald aktivitet";
            this.btnCancelBookedActivity.UseVisualStyleBackColor = true;
            this.btnCancelBookedActivity.Click += new System.EventHandler(this.btnCancelBookedActivity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aktivitetsinformation";
            // 
            // bokadeAktiviteterListBox
            // 
            this.bokadeAktiviteterListBox.FormattingEnabled = true;
            this.bokadeAktiviteterListBox.Location = new System.Drawing.Point(15, 33);
            this.bokadeAktiviteterListBox.Name = "bokadeAktiviteterListBox";
            this.bokadeAktiviteterListBox.Size = new System.Drawing.Size(257, 290);
            this.bokadeAktiviteterListBox.TabIndex = 1;
            this.bokadeAktiviteterListBox.SelectedIndexChanged += new System.EventHandler(this.bokadeAktiviteterListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bokade aktiviteter";
            // 
            // tabPageAlumnFacts
            // 
            this.tabPageAlumnFacts.Controls.Add(this.taBortValtProgramBtn);
            this.tabPageAlumnFacts.Controls.Add(this.Kompetenser);
            this.tabPageAlumnFacts.Controls.Add(this.kompetenserListBox);
            this.tabPageAlumnFacts.Controls.Add(this.nyUtbildningTxtBox);
            this.tabPageAlumnFacts.Controls.Add(this.taBortvaldKompetensBtn);
            this.tabPageAlumnFacts.Controls.Add(this.label11);
            this.tabPageAlumnFacts.Controls.Add(this.programListBox);
            this.tabPageAlumnFacts.Controls.Add(this.LäggTillArbetslivserfarenhetBtn);
            this.tabPageAlumnFacts.Controls.Add(this.nyArbetslivserfarenhetTxtBox);
            this.tabPageAlumnFacts.Controls.Add(this.label8);
            this.tabPageAlumnFacts.Controls.Add(this.läggTillUtbildningBtn);
            this.tabPageAlumnFacts.Controls.Add(this.label5);
            this.tabPageAlumnFacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlumnFacts.Name = "tabPageAlumnFacts";
            this.tabPageAlumnFacts.Size = new System.Drawing.Size(571, 368);
            this.tabPageAlumnFacts.TabIndex = 2;
            this.tabPageAlumnFacts.Text = "Alumnuppgifter";
            this.tabPageAlumnFacts.UseVisualStyleBackColor = true;
            // 
            // taBortValtProgramBtn
            // 
            this.taBortValtProgramBtn.Location = new System.Drawing.Point(417, 156);
            this.taBortValtProgramBtn.Name = "taBortValtProgramBtn";
            this.taBortValtProgramBtn.Size = new System.Drawing.Size(135, 23);
            this.taBortValtProgramBtn.TabIndex = 23;
            this.taBortValtProgramBtn.Text = "Ta bort valt program";
            this.taBortValtProgramBtn.UseVisualStyleBackColor = true;
            this.taBortValtProgramBtn.Click += new System.EventHandler(this.taBortValtProgramBtn_Click);
            // 
            // Kompetenser
            // 
            this.Kompetenser.AutoSize = true;
            this.Kompetenser.Location = new System.Drawing.Point(258, 187);
            this.Kompetenser.Name = "Kompetenser";
            this.Kompetenser.Size = new System.Drawing.Size(69, 13);
            this.Kompetenser.TabIndex = 22;
            this.Kompetenser.Text = "Kompetenser";
            // 
            // kompetenserListBox
            // 
            this.kompetenserListBox.FormattingEnabled = true;
            this.kompetenserListBox.Location = new System.Drawing.Point(261, 203);
            this.kompetenserListBox.Name = "kompetenserListBox";
            this.kompetenserListBox.Size = new System.Drawing.Size(291, 121);
            this.kompetenserListBox.TabIndex = 21;
            // 
            // nyUtbildningTxtBox
            // 
            this.nyUtbildningTxtBox.Location = new System.Drawing.Point(7, 55);
            this.nyUtbildningTxtBox.Name = "nyUtbildningTxtBox";
            this.nyUtbildningTxtBox.Size = new System.Drawing.Size(233, 20);
            this.nyUtbildningTxtBox.TabIndex = 20;
            // 
            // taBortvaldKompetensBtn
            // 
            this.taBortvaldKompetensBtn.Location = new System.Drawing.Point(417, 330);
            this.taBortvaldKompetensBtn.Name = "taBortvaldKompetensBtn";
            this.taBortvaldKompetensBtn.Size = new System.Drawing.Size(135, 23);
            this.taBortvaldKompetensBtn.TabIndex = 19;
            this.taBortvaldKompetensBtn.Text = "Ta bort vald kompetens";
            this.taBortvaldKompetensBtn.UseVisualStyleBackColor = true;
            this.taBortvaldKompetensBtn.Click += new System.EventHandler(this.taBortvaldKompetensBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Program";
            // 
            // programListBox
            // 
            this.programListBox.FormattingEnabled = true;
            this.programListBox.Location = new System.Drawing.Point(261, 29);
            this.programListBox.Name = "programListBox";
            this.programListBox.Size = new System.Drawing.Size(291, 121);
            this.programListBox.TabIndex = 17;
            // 
            // LäggTillArbetslivserfarenhetBtn
            // 
            this.LäggTillArbetslivserfarenhetBtn.Location = new System.Drawing.Point(7, 253);
            this.LäggTillArbetslivserfarenhetBtn.Name = "LäggTillArbetslivserfarenhetBtn";
            this.LäggTillArbetslivserfarenhetBtn.Size = new System.Drawing.Size(233, 23);
            this.LäggTillArbetslivserfarenhetBtn.TabIndex = 11;
            this.LäggTillArbetslivserfarenhetBtn.Text = "Lägg till arbetslivserfarenhet ->";
            this.LäggTillArbetslivserfarenhetBtn.UseVisualStyleBackColor = true;
            this.LäggTillArbetslivserfarenhetBtn.Click += new System.EventHandler(this.LäggTillArbetslivserfarenhetBtn_Click);
            // 
            // nyArbetslivserfarenhetTxtBox
            // 
            this.nyArbetslivserfarenhetTxtBox.Location = new System.Drawing.Point(8, 227);
            this.nyArbetslivserfarenhetTxtBox.Name = "nyArbetslivserfarenhetTxtBox";
            this.nyArbetslivserfarenhetTxtBox.Size = new System.Drawing.Size(233, 20);
            this.nyArbetslivserfarenhetTxtBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kompetenser/Arbetslivserfarenhet";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // läggTillUtbildningBtn
            // 
            this.läggTillUtbildningBtn.Location = new System.Drawing.Point(6, 81);
            this.läggTillUtbildningBtn.Name = "läggTillUtbildningBtn";
            this.läggTillUtbildningBtn.Size = new System.Drawing.Size(233, 23);
            this.läggTillUtbildningBtn.TabIndex = 5;
            this.läggTillUtbildningBtn.Text = "Lägg till utbildning ->";
            this.läggTillUtbildningBtn.UseVisualStyleBackColor = true;
            this.läggTillUtbildningBtn.Click += new System.EventHandler(this.läggTillUtbildningBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Slutförd utbildning vid högskolan i Borås";
            // 
            // tabPageUserData
            // 
            this.tabPageUserData.Controls.Add(this.btnDeleteAccount);
            this.tabPageUserData.Controls.Add(this.btnSaveChanges);
            this.tabPageUserData.Controls.Add(this.ändraEpostTxtBox);
            this.tabPageUserData.Controls.Add(this.label14);
            this.tabPageUserData.Controls.Add(this.ändraEfternamnTxtBox);
            this.tabPageUserData.Controls.Add(this.label13);
            this.tabPageUserData.Controls.Add(this.ändraFörnamnTxtBox);
            this.tabPageUserData.Controls.Add(this.label12);
            this.tabPageUserData.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserData.Name = "tabPageUserData";
            this.tabPageUserData.Size = new System.Drawing.Size(571, 368);
            this.tabPageUserData.TabIndex = 3;
            this.tabPageUserData.Text = "Användaruppgifter";
            this.tabPageUserData.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(7, 339);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Radera konto";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(93, 126);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(115, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Spara ändringar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ändraEpostTxtBox
            // 
            this.ändraEpostTxtBox.Location = new System.Drawing.Point(7, 99);
            this.ändraEpostTxtBox.Name = "ändraEpostTxtBox";
            this.ändraEpostTxtBox.Size = new System.Drawing.Size(202, 20);
            this.ändraEpostTxtBox.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ändra e-postadress";
            // 
            // ändraEfternamnTxtBox
            // 
            this.ändraEfternamnTxtBox.Location = new System.Drawing.Point(7, 60);
            this.ändraEfternamnTxtBox.Name = "ändraEfternamnTxtBox";
            this.ändraEfternamnTxtBox.Size = new System.Drawing.Size(202, 20);
            this.ändraEfternamnTxtBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ändra efternamn";
            // 
            // ändraFörnamnTxtBox
            // 
            this.ändraFörnamnTxtBox.Location = new System.Drawing.Point(7, 21);
            this.ändraFörnamnTxtBox.Name = "ändraFörnamnTxtBox";
            this.ändraFörnamnTxtBox.Size = new System.Drawing.Size(202, 20);
            this.ändraFörnamnTxtBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ändra förnamn";
            // 
            // MainAlumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 426);
            this.Controls.Add(this.tabControlAlumn);
            this.Name = "MainAlumnForm";
            this.Text = "Alumn";
            this.Load += new System.EventHandler(this.MainAlumnForm_Load);
            this.tabControlAlumn.ResumeLayout(false);
            this.tabPageUpcommingActivities.ResumeLayout(false);
            this.tabPageUpcommingActivities.PerformLayout();
            this.tabPageBookedActivities.ResumeLayout(false);
            this.tabPageBookedActivities.PerformLayout();
            this.tabPageAlumnFacts.ResumeLayout(false);
            this.tabPageAlumnFacts.PerformLayout();
            this.tabPageUserData.ResumeLayout(false);
            this.tabPageUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAlumn;
        private System.Windows.Forms.TabPage tabPageUpcommingActivities;
        private System.Windows.Forms.TabPage tabPageBookedActivities;
        private System.Windows.Forms.Button btnBookActivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox informationsutskickListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelBookedActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox bokadeAktiviteterListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageAlumnFacts;
        private System.Windows.Forms.TabPage tabPageUserData;
        private System.Windows.Forms.Button taBortvaldKompetensBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox programListBox;
        private System.Windows.Forms.Button LäggTillArbetslivserfarenhetBtn;
        private System.Windows.Forms.TextBox nyArbetslivserfarenhetTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button läggTillUtbildningBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox ändraEpostTxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ändraEfternamnTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ändraFörnamnTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox aktivitetsBeskrivningTextBox;
        private System.Windows.Forms.RichTextBox aktivitetsinformationRichTextBox;
        private System.Windows.Forms.TextBox nyUtbildningTxtBox;
        private System.Windows.Forms.Label Kompetenser;
        private System.Windows.Forms.ListBox kompetenserListBox;
        private System.Windows.Forms.Button taBortValtProgramBtn;
    }
}