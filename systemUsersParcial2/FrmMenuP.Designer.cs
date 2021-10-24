
namespace systemUsersParcial2
{
    partial class FrmMenuP
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlbLogs = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbtnUsersProjects = new MetroFramework.Controls.MetroButton();
            this.mbtnLogRecord = new MetroFramework.Controls.MetroButton();
            this.mbtnUsersList = new MetroFramework.Controls.MetroButton();
            this.mbtnAdProfile = new MetroFramework.Controls.MetroButton();
            this.labelNameMenu = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(18, 71);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(691, 373);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(683, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.mlbLogs);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mbtnUsersProjects);
            this.metroPanel1.Controls.Add(this.mbtnLogRecord);
            this.metroPanel1.Controls.Add(this.mbtnUsersList);
            this.metroPanel1.Controls.Add(this.mbtnAdProfile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(681, 330);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(106, 289);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 23);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Users List";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(413, 289);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 23);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Users Projects";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbLogs
            // 
            this.mlbLogs.Location = new System.Drawing.Point(413, 122);
            this.mlbLogs.Name = "mlbLogs";
            this.mlbLogs.Size = new System.Drawing.Size(143, 23);
            this.mlbLogs.TabIndex = 16;
            this.mlbLogs.Text = "Log-in Record";
            this.mlbLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(104, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 23);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Admin Profile";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbtnUsersProjects
            // 
            this.mbtnUsersProjects.BackColor = System.Drawing.Color.White;
            this.mbtnUsersProjects.BackgroundImage = global::systemUsersParcial2.Properties.Resources.UsersProjects;
            this.mbtnUsersProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnUsersProjects.Location = new System.Drawing.Point(412, 185);
            this.mbtnUsersProjects.Name = "mbtnUsersProjects";
            this.mbtnUsersProjects.Size = new System.Drawing.Size(144, 101);
            this.mbtnUsersProjects.TabIndex = 14;
            this.mbtnUsersProjects.UseCustomBackColor = true;
            this.mbtnUsersProjects.UseSelectable = true;
            this.mbtnUsersProjects.Click += new System.EventHandler(this.mbtnUsersProjects_Click);
            // 
            // mbtnLogRecord
            // 
            this.mbtnLogRecord.BackColor = System.Drawing.Color.White;
            this.mbtnLogRecord.BackgroundImage = global::systemUsersParcial2.Properties.Resources.log_in_record;
            this.mbtnLogRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnLogRecord.Location = new System.Drawing.Point(413, 18);
            this.mbtnLogRecord.Name = "mbtnLogRecord";
            this.mbtnLogRecord.Size = new System.Drawing.Size(144, 101);
            this.mbtnLogRecord.TabIndex = 13;
            this.mbtnLogRecord.UseCustomBackColor = true;
            this.mbtnLogRecord.UseSelectable = true;
            this.mbtnLogRecord.Click += new System.EventHandler(this.mbtnLogRecord_Click);
            // 
            // mbtnUsersList
            // 
            this.mbtnUsersList.BackColor = System.Drawing.Color.White;
            this.mbtnUsersList.BackgroundImage = global::systemUsersParcial2.Properties.Resources.usersList;
            this.mbtnUsersList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnUsersList.Location = new System.Drawing.Point(106, 185);
            this.mbtnUsersList.Name = "mbtnUsersList";
            this.mbtnUsersList.Size = new System.Drawing.Size(144, 101);
            this.mbtnUsersList.TabIndex = 12;
            this.mbtnUsersList.UseCustomBackColor = true;
            this.mbtnUsersList.UseSelectable = true;
            this.mbtnUsersList.Click += new System.EventHandler(this.mbtnUsersList_Click);
            // 
            // mbtnAdProfile
            // 
            this.mbtnAdProfile.BackColor = System.Drawing.Color.White;
            this.mbtnAdProfile.BackgroundImage = global::systemUsersParcial2.Properties.Resources.profile;
            this.mbtnAdProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbtnAdProfile.Location = new System.Drawing.Point(104, 18);
            this.mbtnAdProfile.Name = "mbtnAdProfile";
            this.mbtnAdProfile.Size = new System.Drawing.Size(144, 101);
            this.mbtnAdProfile.TabIndex = 11;
            this.mbtnAdProfile.UseCustomBackColor = true;
            this.mbtnAdProfile.UseSelectable = true;
            this.mbtnAdProfile.Click += new System.EventHandler(this.mbtnAdProfile_Click);
            // 
            // labelNameMenu
            // 
            this.labelNameMenu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNameMenu.Location = new System.Drawing.Point(83, 26);
            this.labelNameMenu.Name = "labelNameMenu";
            this.labelNameMenu.Size = new System.Drawing.Size(106, 24);
            this.labelNameMenu.TabIndex = 1;
            // 
            // FrmMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 459);
            this.Controls.Add(this.labelNameMenu);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmMenuP";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuP_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuP_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlbLogs;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnUsersProjects;
        private MetroFramework.Controls.MetroButton mbtnLogRecord;
        private MetroFramework.Controls.MetroButton mbtnUsersList;
        private MetroFramework.Controls.MetroButton mbtnAdProfile;
        private System.Windows.Forms.Label labelNameMenu;
    }
}