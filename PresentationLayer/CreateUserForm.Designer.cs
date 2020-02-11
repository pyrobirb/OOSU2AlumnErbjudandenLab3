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
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(95, 24);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdmin.TabIndex = 1;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administratör";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn";
            // 
            // textBoxUserNameInput
            // 
            this.textBoxUserNameInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxUserNameInput.Location = new System.Drawing.Point(26, 65);
            this.textBoxUserNameInput.Name = "textBoxUserNameInput";
            this.textBoxUserNameInput.Size = new System.Drawing.Size(210, 20);
            this.textBoxUserNameInput.TabIndex = 3;
            this.textBoxUserNameInput.Text = "Epost eller anst.nr.";
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
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPasswordInput.Location = new System.Drawing.Point(26, 104);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(210, 20);
            this.textBoxPasswordInput.TabIndex = 5;
            this.textBoxPasswordInput.Text = "Minst 10 tecken";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(136, 131);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Skapa konto";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alumner använder epost som användarnamn.\r\nAdministratörer använder sitt Anstälnni" +
    "ngsnummer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lösenorder måste vara minst 10 tecken långt.";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 175);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonAlumn);
            this.Name = "CreateUserForm";
            this.Text = "Skapa konto";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlumn;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}