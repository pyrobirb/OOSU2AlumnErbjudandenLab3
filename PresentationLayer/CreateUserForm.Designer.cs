namespace PresentationLayer
{
    partial class CreateUserForm
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
            this.radioButtonAlumn = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AnvändarnamnTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LösenordTxtBox = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FörnamnTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EfternamnTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TillbakaKnapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAlumn
            // 
            this.radioButtonAlumn.AutoSize = true;
            this.radioButtonAlumn.Location = new System.Drawing.Point(23, 24);
            this.radioButtonAlumn.Name = "radioButtonAlumn";
            this.radioButtonAlumn.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAlumn.TabIndex = 0;
            this.radioButtonAlumn.TabStop = true;
            this.radioButtonAlumn.Text = "Alumn";
            this.radioButtonAlumn.UseVisualStyleBackColor = true;
            // 
            // radioButtonPersonal
            // 
            this.radioButtonPersonal.AutoSize = true;
            this.radioButtonPersonal.Location = new System.Drawing.Point(95, 24);
            this.radioButtonPersonal.Name = "radioButtonPersonal";
            this.radioButtonPersonal.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPersonal.TabIndex = 1;
            this.radioButtonPersonal.TabStop = true;
            this.radioButtonPersonal.Text = "Personal";
            this.radioButtonPersonal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn / Epost";
            // 
            // AnvändarnamnTxtBox
            // 
            this.AnvändarnamnTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AnvändarnamnTxtBox.Location = new System.Drawing.Point(26, 65);
            this.AnvändarnamnTxtBox.Name = "AnvändarnamnTxtBox";
            this.AnvändarnamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.AnvändarnamnTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord";
            // 
            // LösenordTxtBox
            // 
            this.LösenordTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LösenordTxtBox.Location = new System.Drawing.Point(26, 104);
            this.LösenordTxtBox.Name = "LösenordTxtBox";
            this.LösenordTxtBox.Size = new System.Drawing.Size(210, 20);
            this.LösenordTxtBox.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(137, 222);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Skapa konto";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alumner använder epost som användarnamn.\r\n Personal använder sitt Anställningsnum" +
    "mer.";
            // 
            // FörnamnTxtBox
            // 
            this.FörnamnTxtBox.Location = new System.Drawing.Point(26, 143);
            this.FörnamnTxtBox.Name = "FörnamnTxtBox";
            this.FörnamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.FörnamnTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Förnamn";
            // 
            // EfternamnTxtBox
            // 
            this.EfternamnTxtBox.Location = new System.Drawing.Point(26, 184);
            this.EfternamnTxtBox.Name = "EfternamnTxtBox";
            this.EfternamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.EfternamnTxtBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Efternamn";
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(437, 12);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(75, 23);
            this.TillbakaKnapp.TabIndex = 12;
            this.TillbakaKnapp.Text = "Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.TillbakaKnapp_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 263);
            this.Controls.Add(this.TillbakaKnapp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EfternamnTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FörnamnTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.LösenordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnvändarnamnTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonPersonal);
            this.Controls.Add(this.radioButtonAlumn);
            this.Name = "CreateUserForm";
            this.Text = "Skapa konto";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlumn;
        private System.Windows.Forms.RadioButton radioButtonPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnvändarnamnTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LösenordTxtBox;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FörnamnTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EfternamnTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TillbakaKnapp;
    }
}