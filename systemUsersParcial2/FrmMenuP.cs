using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Forms;


namespace systemUsersParcial2
{
    public partial class FrmMenuP : MetroForm
    {

        public struct Names2
        {
            public string name2;
        }
        public FrmMenuP(FrmLogin.Names info)
        {
            InitializeComponent();
            labelNameMenu.Text = info.name;
        }

        private void FrmMenuP_Load(object sender, EventArgs e)
        {
            if (labelNameMenu.Text != "Admin" && labelNameMenu.Text != "admin")
            {
                mbtnLogRecord.Hide();
                mlbLogs.Hide();
                
            }
            
        }

        

        private void tpAdmin_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void mbtnAdProfile_Click(object sender, EventArgs e)
        {
            Names2 info2;
            info2.name2 = labelNameMenu.Text;
            FrmProfile forma = new FrmProfile(info2);
            forma.Show();
            
        }

        private void mbtnUsersList_Click(object sender, EventArgs e)
        {
            FrmUserList forma = new FrmUserList();
            forma.Show();
        }

        private void mbtnLogRecord_Click(object sender, EventArgs e)
        {
            FrmLogRecord forma = new FrmLogRecord();
            forma.Show();
        }

        private void mbtnUsersProjects_Click(object sender, EventArgs e)
        {
            FrmUsersProject forma = new FrmUsersProject();
            forma.Show();
        }

        private void FrmMenuP_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
