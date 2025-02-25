namespace Ergasia_AAY_2023_24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.textBoxLoginUsernmane = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.login_RegisterHere = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Button();
            this.pictureBoxLoginPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginUsername = new System.Windows.Forms.PictureBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogoMuseum = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginUsername)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoMuseum)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(741, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(846, 71);
            this.label2.TabIndex = 4;
            this.label2.Text = "Μουσείο Τέχνης και Καλλιτεχνών";
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelLoginUsername.Location = new System.Drawing.Point(837, 305);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(278, 50);
            this.labelLoginUsername.TabIndex = 5;
            this.labelLoginUsername.Text = "Όνομα Χρήστη";
            // 
            // textBoxLoginUsernmane
            // 
            this.textBoxLoginUsernmane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginUsernmane.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxLoginUsernmane.Location = new System.Drawing.Point(848, 360);
            this.textBoxLoginUsernmane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginUsernmane.Multiline = true;
            this.textBoxLoginUsernmane.Name = "textBoxLoginUsernmane";
            this.textBoxLoginUsernmane.Size = new System.Drawing.Size(631, 64);
            this.textBoxLoginUsernmane.TabIndex = 7;
            this.textBoxLoginUsernmane.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLoginUsernmane_KeyDown);
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelLoginPassword.Location = new System.Drawing.Point(837, 479);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(375, 50);
            this.labelLoginPassword.TabIndex = 9;
            this.labelLoginPassword.Text = "Κωδικός Πρόσβασης";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(1165, 610);
            this.checkBoxShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(311, 45);
            this.checkBoxShowPass.TabIndex = 12;
            this.checkBoxShowPass.Text = "Εμφάνιση Κωδικού";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(1440, 794);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(213, 76);
            this.ButtonLogin.TabIndex = 13;
            this.ButtonLogin.Text = "Σύνδεση";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(896, 959);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Δεν έχεις λογαριασμό;";
            // 
            // login_RegisterHere
            // 
            this.login_RegisterHere.AutoSize = true;
            this.login_RegisterHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_RegisterHere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login_RegisterHere.ForeColor = System.Drawing.SystemColors.GrayText;
            this.login_RegisterHere.Location = new System.Drawing.Point(1213, 959);
            this.login_RegisterHere.Name = "login_RegisterHere";
            this.login_RegisterHere.Size = new System.Drawing.Size(289, 41);
            this.login_RegisterHere.TabIndex = 15;
            this.login_RegisterHere.Text = "Κάνε Εγγραφή εδώ";
            this.login_RegisterHere.Click += new System.EventHandler(this.login_RegisterHere_Click);
            this.login_RegisterHere.MouseEnter += new System.EventHandler(this.login_RegisterHere_MouseEnter);
            this.login_RegisterHere.MouseLeave += new System.EventHandler(this.login_RegisterHere_MouseLeave);
            // 
            // login_close
            // 
            this.login_close.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_close.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login_close.ForeColor = System.Drawing.Color.White;
            this.login_close.Location = new System.Drawing.Point(1643, 19);
            this.login_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(64, 64);
            this.login_close.TabIndex = 17;
            this.login_close.Text = "X";
            this.login_close.UseVisualStyleBackColor = false;
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // pictureBoxLoginPassword
            // 
            this.pictureBoxLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLoginPassword.ErrorImage = global::Ergasia_AAY_2023_24.Properties.Resources.LogoPassword;
            this.pictureBoxLoginPassword.Image = global::Ergasia_AAY_2023_24.Properties.Resources.LogoPassword;
            this.pictureBoxLoginPassword.InitialImage = global::Ergasia_AAY_2023_24.Properties.Resources.LogoPassword;
            this.pictureBoxLoginPassword.Location = new System.Drawing.Point(1488, 527);
            this.pictureBoxLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLoginPassword.Name = "pictureBoxLoginPassword";
            this.pictureBoxLoginPassword.Size = new System.Drawing.Size(75, 79);
            this.pictureBoxLoginPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoginPassword.TabIndex = 11;
            this.pictureBoxLoginPassword.TabStop = false;
            // 
            // pictureBoxLoginUsername
            // 
            this.pictureBoxLoginUsername.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginUsername.ErrorImage = global::Ergasia_AAY_2023_24.Properties.Resources.usernameLogo;
            this.pictureBoxLoginUsername.Image = global::Ergasia_AAY_2023_24.Properties.Resources.usernameLogo;
            this.pictureBoxLoginUsername.InitialImage = global::Ergasia_AAY_2023_24.Properties.Resources.usernameLogo;
            this.pictureBoxLoginUsername.Location = new System.Drawing.Point(1488, 362);
            this.pictureBoxLoginUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLoginUsername.Name = "pictureBoxLoginUsername";
            this.pictureBoxLoginUsername.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLoginUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginUsername.TabIndex = 10;
            this.pictureBoxLoginUsername.TabStop = false;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(848, 534);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginPassword.Multiline = true;
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(631, 64);
            this.textBoxLoginPassword.TabIndex = 18;
            this.textBoxLoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLoginPassword_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Ergasia_AAY_2023_24.Properties.Resources.LoginBackImage;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxLogoMuseum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 1109);
            this.panel1.TabIndex = 19;
            // 
            // pictureBoxLogoMuseum
            // 
            this.pictureBoxLogoMuseum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoMuseum.ErrorImage = global::Ergasia_AAY_2023_24.Properties.Resources.logo;
            this.pictureBoxLogoMuseum.Image = global::Ergasia_AAY_2023_24.Properties.Resources.logo;
            this.pictureBoxLogoMuseum.InitialImage = global::Ergasia_AAY_2023_24.Properties.Resources.logo;
            this.pictureBoxLogoMuseum.Location = new System.Drawing.Point(149, 417);
            this.pictureBoxLogoMuseum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogoMuseum.Name = "pictureBoxLogoMuseum";
            this.pictureBoxLogoMuseum.Size = new System.Drawing.Size(368, 310);
            this.pictureBoxLogoMuseum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoMuseum.TabIndex = 3;
            this.pictureBoxLogoMuseum.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Αρμονία Πολιτσιμού ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(837, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 50);
            this.label3.TabIndex = 20;
            this.label3.Text = "Είδος Χρήστη ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Πελάτης ",
            "Υπάλληλος"});
            this.comboBox1.Location = new System.Drawing.Point(848, 730);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 39);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1731, 1011);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.login_RegisterHere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.pictureBoxLoginPassword);
            this.Controls.Add(this.pictureBoxLoginUsername);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.textBoxLoginUsernmane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLoginUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginUsername)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoMuseum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.TextBox textBoxLoginUsernmane;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.PictureBox pictureBoxLoginUsername;
        private System.Windows.Forms.PictureBox pictureBoxLoginPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label login_RegisterHere;
        private System.Windows.Forms.Button login_close;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoMuseum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

