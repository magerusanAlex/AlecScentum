namespace AlecScentum
{
    partial class StartAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartAppForm));
            this.lblStartAppFormNicknameOrMail = new System.Windows.Forms.Label();
            this.lblStartAppFormPassword = new System.Windows.Forms.Label();
            this.txtbStartAppFormNicknameOrMail = new System.Windows.Forms.TextBox();
            this.txtbStartAppFormPassword = new System.Windows.Forms.TextBox();
            this.btnStartAppFormSubmitLogIn = new System.Windows.Forms.Button();
            this.lblStartAppFormAskIfDoNotHaveAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExitApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartAppFormNicknameOrMail
            // 
            this.lblStartAppFormNicknameOrMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartAppFormNicknameOrMail.AutoSize = true;
            this.lblStartAppFormNicknameOrMail.BackColor = System.Drawing.Color.Transparent;
            this.lblStartAppFormNicknameOrMail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAppFormNicknameOrMail.Location = new System.Drawing.Point(307, 242);
            this.lblStartAppFormNicknameOrMail.Name = "lblStartAppFormNicknameOrMail";
            this.lblStartAppFormNicknameOrMail.Size = new System.Drawing.Size(161, 24);
            this.lblStartAppFormNicknameOrMail.TabIndex = 1;
            this.lblStartAppFormNicknameOrMail.Text = "Nickname or Mail";
            this.lblStartAppFormNicknameOrMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartAppFormPassword
            // 
            this.lblStartAppFormPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartAppFormPassword.AutoSize = true;
            this.lblStartAppFormPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblStartAppFormPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAppFormPassword.Location = new System.Drawing.Point(360, 297);
            this.lblStartAppFormPassword.Name = "lblStartAppFormPassword";
            this.lblStartAppFormPassword.Size = new System.Drawing.Size(90, 24);
            this.lblStartAppFormPassword.TabIndex = 2;
            this.lblStartAppFormPassword.Text = "Password";
            this.lblStartAppFormPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbStartAppFormNicknameOrMail
            // 
            this.txtbStartAppFormNicknameOrMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbStartAppFormNicknameOrMail.Location = new System.Drawing.Point(492, 242);
            this.txtbStartAppFormNicknameOrMail.Name = "txtbStartAppFormNicknameOrMail";
            this.txtbStartAppFormNicknameOrMail.Size = new System.Drawing.Size(150, 22);
            this.txtbStartAppFormNicknameOrMail.TabIndex = 3;
            // 
            // txtbStartAppFormPassword
            // 
            this.txtbStartAppFormPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbStartAppFormPassword.Location = new System.Drawing.Point(492, 299);
            this.txtbStartAppFormPassword.Name = "txtbStartAppFormPassword";
            this.txtbStartAppFormPassword.PasswordChar = '*';
            this.txtbStartAppFormPassword.Size = new System.Drawing.Size(150, 22);
            this.txtbStartAppFormPassword.TabIndex = 4;
            // 
            // btnStartAppFormSubmitLogIn
            // 
            this.btnStartAppFormSubmitLogIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartAppFormSubmitLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnStartAppFormSubmitLogIn.Location = new System.Drawing.Point(342, 367);
            this.btnStartAppFormSubmitLogIn.Name = "btnStartAppFormSubmitLogIn";
            this.btnStartAppFormSubmitLogIn.Size = new System.Drawing.Size(126, 48);
            this.btnStartAppFormSubmitLogIn.TabIndex = 5;
            this.btnStartAppFormSubmitLogIn.Text = "Submit";
            this.btnStartAppFormSubmitLogIn.UseVisualStyleBackColor = false;
            this.btnStartAppFormSubmitLogIn.Click += new System.EventHandler(this.btnStartAppFormSubmitLogIn_Click);
            // 
            // lblStartAppFormAskIfDoNotHaveAccount
            // 
            this.lblStartAppFormAskIfDoNotHaveAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartAppFormAskIfDoNotHaveAccount.AutoSize = true;
            this.lblStartAppFormAskIfDoNotHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblStartAppFormAskIfDoNotHaveAccount.Location = new System.Drawing.Point(489, 375);
            this.lblStartAppFormAskIfDoNotHaveAccount.Name = "lblStartAppFormAskIfDoNotHaveAccount";
            this.lblStartAppFormAskIfDoNotHaveAccount.Size = new System.Drawing.Size(149, 32);
            this.lblStartAppFormAskIfDoNotHaveAccount.TabIndex = 11;
            this.lblStartAppFormAskIfDoNotHaveAccount.Text = "Don\'t have an account? \r\nClick here!";
            this.lblStartAppFormAskIfDoNotHaveAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartAppFormAskIfDoNotHaveAccount.Click += new System.EventHandler(this.lblStartAppFormAskIfDoNotHaveAccount_Click);
            this.lblStartAppFormAskIfDoNotHaveAccount.MouseEnter += new System.EventHandler(this.lblStartAppFormAskIfDoNotHaveAccount_MouseEnter);
            this.lblStartAppFormAskIfDoNotHaveAccount.MouseLeave += new System.EventHandler(this.lblStartAppFormAskIfDoNotHaveAccount_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::AlecScentum.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(946, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApp.ForeColor = System.Drawing.Color.Red;
            this.btnExitApp.Location = new System.Drawing.Point(438, 477);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(78, 49);
            this.btnExitApp.TabIndex = 13;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // StartAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlecScentum.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 538);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStartAppFormAskIfDoNotHaveAccount);
            this.Controls.Add(this.txtbStartAppFormNicknameOrMail);
            this.Controls.Add(this.lblStartAppFormNicknameOrMail);
            this.Controls.Add(this.btnStartAppFormSubmitLogIn);
            this.Controls.Add(this.lblStartAppFormPassword);
            this.Controls.Add(this.txtbStartAppFormPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start App Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStartAppFormNicknameOrMail;
        private System.Windows.Forms.Label lblStartAppFormPassword;
        private System.Windows.Forms.TextBox txtbStartAppFormNicknameOrMail;
        private System.Windows.Forms.TextBox txtbStartAppFormPassword;
        private System.Windows.Forms.Button btnStartAppFormSubmitLogIn;
        private System.Windows.Forms.Label lblStartAppFormAskIfDoNotHaveAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitApp;
    }
}

