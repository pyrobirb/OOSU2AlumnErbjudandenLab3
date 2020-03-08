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
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(423, 12);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(75, 23);
            this.TillbakaKnapp.TabIndex = 23;
            this.TillbakaKnapp.Text = "Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.TillbakaKnapp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Efternamn";
            // 
            // EfternamnTxtBox
            // 
            this.EfternamnTxtBox.Location = new System.Drawing.Point(12, 184);
            this.EfternamnTxtBox.Name = "EfternamnTxtBox";
            this.EfternamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.EfternamnTxtBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Förnamn";
            // 
            // FörnamnTxtBox
            // 
            this.FörnamnTxtBox.Location = new System.Drawing.Point(12, 143);
            this.FörnamnTxtBox.Name = "FörnamnTxtBox";
            this.FörnamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.FörnamnTxtBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Personal använder sitt Anställningsnummer.";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(123, 222);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAccount.TabIndex = 17;
            this.btnCreateAccount.Text = "Skapa konto";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // LösenordTxtBox
            // 
            this.LösenordTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LösenordTxtBox.Location = new System.Drawing.Point(12, 104);
            this.LösenordTxtBox.Name = "LösenordTxtBox";
            this.LösenordTxtBox.Size = new System.Drawing.Size(210, 20);
            this.LösenordTxtBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lösenord";
            // 
            // AnvändarnamnTxtBox
            // 
            this.AnvändarnamnTxtBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AnvändarnamnTxtBox.Location = new System.Drawing.Point(12, 65);
            this.AnvändarnamnTxtBox.Name = "AnvändarnamnTxtBox";
            this.AnvändarnamnTxtBox.Size = new System.Drawing.Size(210, 20);
            this.AnvändarnamnTxtBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Användarnamn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Skapa personalkonto";
            // 
            // CreatePersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 270);
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
        private System.Windows.Forms.Label label6;
    }
}