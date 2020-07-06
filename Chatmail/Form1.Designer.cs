namespace Chatmail
{
    partial class Chatmail
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxSend = new System.Windows.Forms.GroupBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxReceiver = new System.Windows.Forms.ComboBox();
            this.labelReceiver = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeUser = new System.Windows.Forms.GroupBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxReceive = new System.Windows.Forms.GroupBox();
            this.richTextBoxReceive = new System.Windows.Forms.RichTextBox();
            this.groupBoxSend.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxChangeUser.SuspendLayout();
            this.groupBoxReceive.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(7, 32);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(192, 21);
            this.comboBoxUser.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 16);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(86, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User auswählen:";
            // 
            // groupBoxSend
            // 
            this.groupBoxSend.Controls.Add(this.richTextBoxSend);
            this.groupBoxSend.Controls.Add(this.buttonSend);
            this.groupBoxSend.Controls.Add(this.comboBoxReceiver);
            this.groupBoxSend.Controls.Add(this.labelReceiver);
            this.groupBoxSend.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSend.Name = "groupBoxSend";
            this.groupBoxSend.Size = new System.Drawing.Size(480, 126);
            this.groupBoxSend.TabIndex = 2;
            this.groupBoxSend.TabStop = false;
            this.groupBoxSend.Text = "Nachricht verfassen";
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Location = new System.Drawing.Point(6, 46);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(468, 74);
            this.richTextBoxSend.TabIndex = 3;
            this.richTextBoxSend.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(399, 17);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Senden";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSenden_Click);
            // 
            // comboBoxReceiver
            // 
            this.comboBoxReceiver.FormattingEnabled = true;
            this.comboBoxReceiver.Location = new System.Drawing.Point(85, 19);
            this.comboBoxReceiver.Name = "comboBoxReceiver";
            this.comboBoxReceiver.Size = new System.Drawing.Size(275, 21);
            this.comboBoxReceiver.TabIndex = 1;
            // 
            // labelReceiver
            // 
            this.labelReceiver.AutoSize = true;
            this.labelReceiver.Location = new System.Drawing.Point(3, 22);
            this.labelReceiver.Name = "labelReceiver";
            this.labelReceiver.Size = new System.Drawing.Size(58, 13);
            this.labelReceiver.TabIndex = 0;
            this.labelReceiver.Text = "Empfänger";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonStart);
            this.groupBoxLogin.Controls.Add(this.comboBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(13, 340);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(480, 92);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // groupBoxChangeUser
            // 
            this.groupBoxChangeUser.Controls.Add(this.buttonLogout);
            this.groupBoxChangeUser.Location = new System.Drawing.Point(13, 339);
            this.groupBoxChangeUser.Name = "groupBoxChangeUser";
            this.groupBoxChangeUser.Size = new System.Drawing.Size(480, 53);
            this.groupBoxChangeUser.TabIndex = 5;
            this.groupBoxChangeUser.TabStop = false;
            this.groupBoxChangeUser.Text = "User wechseln";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(6, 19);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(86, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "User wechseln";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStarten_Click);
            // 
            // groupBoxReceive
            // 
            this.groupBoxReceive.Controls.Add(this.richTextBoxReceive);
            this.groupBoxReceive.Location = new System.Drawing.Point(13, 146);
            this.groupBoxReceive.Name = "groupBoxReceive";
            this.groupBoxReceive.Size = new System.Drawing.Size(480, 187);
            this.groupBoxReceive.TabIndex = 3;
            this.groupBoxReceive.TabStop = false;
            this.groupBoxReceive.Text = "Empfangene Nachrichten";
            // 
            // richTextBoxReceive
            // 
            this.richTextBoxReceive.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxReceive.Name = "richTextBoxReceive";
            this.richTextBoxReceive.Size = new System.Drawing.Size(467, 161);
            this.richTextBoxReceive.TabIndex = 0;
            this.richTextBoxReceive.Text = "";
            // 
            // Chatmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 444);
            this.Controls.Add(this.groupBoxChangeUser);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxSend);
            this.Controls.Add(this.groupBoxReceive);
            this.Name = "Chatmail";
            this.Text = "Chatmail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSend.ResumeLayout(false);
            this.groupBoxSend.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxChangeUser.ResumeLayout(false);
            this.groupBoxReceive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxSend;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxReceiver;
        private System.Windows.Forms.Label labelReceiver;
        private System.Windows.Forms.GroupBox groupBoxReceive;
        private System.Windows.Forms.RichTextBox richTextBoxReceive;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxChangeUser;
        private System.Windows.Forms.Button buttonLogout;
    }
}

