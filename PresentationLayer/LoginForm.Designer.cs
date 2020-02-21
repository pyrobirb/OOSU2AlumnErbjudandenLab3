namespace PresentationLayer
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LösenordTxtBox = new System.Windows.Forms.TextBox();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.AnvändarnamnTextBox = new System.Windows.Forms.TextBox();
            this.FelInlogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inloggning";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogIn.Location = new System.Drawing.Point(66, 145);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Logga in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Användarnamn eller epost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lösenord:";
            // 
            // LösenordTxtBox
            // 
            this.LösenordTxtBox.Location = new System.Drawing.Point(32, 106);
            this.LösenordTxtBox.Name = "LösenordTxtBox";
            this.LösenordTxtBox.PasswordChar = '*';
            this.LösenordTxtBox.Size = new System.Drawing.Size(156, 20);
            this.LösenordTxtBox.TabIndex = 5;
            this.LösenordTxtBox.Text = "pers";
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCreateAccount.Location = new System.Drawing.Point(73, 169);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(68, 13);
            this.labelCreateAccount.TabIndex = 6;
            this.labelCreateAccount.Text = "Skapa konto";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            // 
            // AnvändarnamnTextBox
            // 
            this.AnvändarnamnTextBox.Location = new System.Drawing.Point(32, 65);
            this.AnvändarnamnTextBox.Name = "AnvändarnamnTextBox";
            this.AnvändarnamnTextBox.Size = new System.Drawing.Size(156, 20);
            this.AnvändarnamnTextBox.TabIndex = 7;
            this.AnvändarnamnTextBox.Text = "P5500";
            this.AnvändarnamnTextBox.TextChanged += new System.EventHandler(this.AnvändarnamnTextBox_TextChanged);
            // 
            // FelInlogLabel
            // 
            this.FelInlogLabel.AutoSize = true;
            this.FelInlogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FelInlogLabel.Location = new System.Drawing.Point(29, 129);
            this.FelInlogLabel.Name = "FelInlogLabel";
            this.FelInlogLabel.Size = new System.Drawing.Size(160, 13);
            this.FelInlogLabel.TabIndex = 8;
            this.FelInlogLabel.Text = "Fel användarnamn eller lösenord";
            this.FelInlogLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(217, 197);
            this.Controls.Add(this.FelInlogLabel);
            this.Controls.Add(this.AnvändarnamnTextBox);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.LösenordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "AlumnAppen";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LösenordTxtBox;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.TextBox AnvändarnamnTextBox;
        private System.Windows.Forms.Label FelInlogLabel;
    }
}

