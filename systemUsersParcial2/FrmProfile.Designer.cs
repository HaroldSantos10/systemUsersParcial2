
namespace systemUsersParcial2
{
    partial class FrmProfile
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mlUserName = new MetroFramework.Controls.MetroLabel();
            this.mlCompName = new MetroFramework.Controls.MetroLabel();
            this.mlEmail = new MetroFramework.Controls.MetroLabel();
            this.mlRegisDate = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(284, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "User Name: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(284, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Email: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(284, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Register Date:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(284, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Complete Name:";
            // 
            // mlUserName
            // 
            this.mlUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlUserName.Location = new System.Drawing.Point(371, 75);
            this.mlUserName.Name = "mlUserName";
            this.mlUserName.Size = new System.Drawing.Size(234, 25);
            this.mlUserName.TabIndex = 5;
            this.mlUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlCompName
            // 
            this.mlCompName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlCompName.Location = new System.Drawing.Point(412, 115);
            this.mlCompName.Name = "mlCompName";
            this.mlCompName.Size = new System.Drawing.Size(234, 25);
            this.mlCompName.TabIndex = 6;
            this.mlCompName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlEmail
            // 
            this.mlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlEmail.Location = new System.Drawing.Point(334, 152);
            this.mlEmail.Name = "mlEmail";
            this.mlEmail.Size = new System.Drawing.Size(234, 25);
            this.mlEmail.TabIndex = 7;
            this.mlEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlRegisDate
            // 
            this.mlRegisDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlRegisDate.Location = new System.Drawing.Point(393, 194);
            this.mlRegisDate.Name = "mlRegisDate";
            this.mlRegisDate.Size = new System.Drawing.Size(234, 25);
            this.mlRegisDate.TabIndex = 8;
            this.mlRegisDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlRegisDate.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::systemUsersParcial2.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(53, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelName.Location = new System.Drawing.Point(48, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(106, 24);
            this.labelName.TabIndex = 9;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(765, 328);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.mlRegisDate);
            this.Controls.Add(this.mlEmail);
            this.Controls.Add(this.mlCompName);
            this.Controls.Add(this.mlUserName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel mlUserName;
        private MetroFramework.Controls.MetroLabel mlCompName;
        private MetroFramework.Controls.MetroLabel mlEmail;
        private MetroFramework.Controls.MetroLabel mlRegisDate;
        private System.Windows.Forms.Label labelName;
    }
}