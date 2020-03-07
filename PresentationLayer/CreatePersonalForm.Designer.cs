namespace PresentationLayer
{
    partial class CreatePersonalForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.TillbakaKnapp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EfternamnTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FörnamnTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.LösenordTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnvändarnamnTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Skapa Personalkonto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(655, 46);
            this.TillbakaKnapp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(112, 35);
            this.TillbakaKnapp.TabIndex = 24;
            this.TillbakaKnapp.Text = "Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.TillbakaKnapp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Efternamn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EfternamnTxtBox
            // 
            this.EfternamnTxtBox.Location = new System.Drawing.Point(38, 311);
            this.EfternamnTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EfternamnTxtBox.Name = "EfternamnTxtBox";
            this.EfternamnTxtBox.Size = new System.Drawing.Size(313, 26);
            this.EfternamnTxtBox.TabIndex = 22;
            this.EfternamnTxtBox.TextChanged += new System.EventHandler(this.EfternamnTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Förnamn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FörnamnTxtBox
            // 
            this.FörnamnTxtBox.Location = new System.Drawing.Point(38, 248);
            this.FörnamnTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FörnamnTxtBox.Name = "FörnamnTxtBox";
            this.FörnamnTxtBox.Size = new System.Drawing.Size(313, 26);
            this.FörnamnTxtBox.TabIndex = 20;
            this.FörnamnTxtBox.TextChanged += new System.EventHandler(this.FörnamnTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Personal använder Id som användarnamn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(205, 370);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(148, 35);
            this.btnCreateAccount.TabIndex = 18;
            this.btnCreateAccount.Text = "Skapa konto";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // LösenordTxtBox
            // 
            this.LösenordTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LösenordTxtBox.Location = new System.Drawing.Point(38, 188);
            this.LösenordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LösenordTxtBox.Name = "LösenordTxtBox";
            this.LösenordTxtBox.Size = new System.Drawing.Size(313, 26);
            this.LösenordTxtBox.TabIndex = 17;
            this.LösenordTxtBox.TextChanged += new System.EventHandler(this.LösenordTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lösenord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AnvändarnamnTxtBox
            // 
            this.AnvändarnamnTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AnvändarnamnTxtBox.Location = new System.Drawing.Point(38, 128);
            this.AnvändarnamnTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnvändarnamnTxtBox.Name = "AnvändarnamnTxtBox";
            this.AnvändarnamnTxtBox.Size = new System.Drawing.Size(313, 26);
            this.AnvändarnamnTxtBox.TabIndex = 15;
            this.AnvändarnamnTxtBox.TextChanged += new System.EventHandler(this.AnvändarnamnTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Användarnamn / Epost";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreatePersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
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
            this.Name = "CreatePersonalForm";
            this.Text = "CreatePersonalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TillbakaKnapp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EfternamnTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FörnamnTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox LösenordTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnvändarnamnTxtBox;
        private System.Windows.Forms.Label label1;
    }
}