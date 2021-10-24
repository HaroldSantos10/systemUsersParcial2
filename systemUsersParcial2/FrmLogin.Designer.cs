
namespace systemUsersParcial2
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUser = new MetroFramework.Controls.MetroTextBox();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtlSignUp = new MetroFramework.Controls.MetroLink();
            this.mbtnContinue = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(44, 264);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "User: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(44, 300);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password:";
            // 
            // mtxtUser
            // 
            // 
            // 
            // 
            this.mtxtUser.CustomButton.Image = null;
            this.mtxtUser.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.mtxtUser.CustomButton.Name = "";
            this.mtxtUser.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.mtxtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUser.CustomButton.TabIndex = 1;
            this.mtxtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUser.CustomButton.UseSelectable = true;
            this.mtxtUser.CustomButton.Visible = false;
            this.mtxtUser.Lines = new string[0];
            this.mtxtUser.Location = new System.Drawing.Point(90, 263);
            this.mtxtUser.MaxLength = 32767;
            this.mtxtUser.Name = "mtxtUser";
            this.mtxtUser.PasswordChar = '\0';
            this.mtxtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUser.SelectedText = "";
            this.mtxtUser.SelectionLength = 0;
            this.mtxtUser.SelectionStart = 0;
            this.mtxtUser.ShortcutsEnabled = true;
            this.mtxtUser.Size = new System.Drawing.Size(220, 20);
            this.mtxtUser.TabIndex = 3;
            this.mtxtUser.UseSelectable = true;
            this.mtxtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(120, 300);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '●';
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.Size = new System.Drawing.Size(183, 20);
            this.mtxtPassword.TabIndex = 4;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.UseSystemPasswordChar = true;
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(72, 387);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(177, 38);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "If you don´t have an account \r\nyou can register now!";
            // 
            // mtlSignUp
            // 
            this.mtlSignUp.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtlSignUp.ForeColor = System.Drawing.Color.Blue;
            this.mtlSignUp.Location = new System.Drawing.Point(206, 403);
            this.mtlSignUp.Name = "mtlSignUp";
            this.mtlSignUp.Size = new System.Drawing.Size(59, 22);
            this.mtlSignUp.TabIndex = 6;
            this.mtlSignUp.Text = "Sign up";
            this.mtlSignUp.UseCustomForeColor = true;
            this.mtlSignUp.UseSelectable = true;
            this.mtlSignUp.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // mbtnContinue
            // 
            this.mbtnContinue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mbtnContinue.Location = new System.Drawing.Point(88, 344);
            this.mbtnContinue.Name = "mbtnContinue";
            this.mbtnContinue.Size = new System.Drawing.Size(177, 31);
            this.mbtnContinue.TabIndex = 7;
            this.mbtnContinue.Text = "Continue";
            this.mbtnContinue.UseCustomBackColor = true;
            this.mbtnContinue.UseSelectable = true;
            this.mbtnContinue.Click += new System.EventHandler(this.mbtnContinue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::systemUsersParcial2.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 462);
            this.Controls.Add(this.mbtnContinue);
            this.Controls.Add(this.mtlSignUp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.mtxtUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmLogin";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtxtUser;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink mtlSignUp;
        private MetroFramework.Controls.MetroButton mbtnContinue;
    }
}

