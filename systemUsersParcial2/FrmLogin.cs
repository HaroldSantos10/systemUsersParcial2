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
    public partial class FrmLogin : MetroForm 
    {
        public struct Names
        {
            public string name;
            
        }


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            FrmSignUp forma = new FrmSignUp();
            forma.Show();
            this.Hide();
        }

        private void mbtnContinue_Click(object sender, EventArgs e)
        {
            Names info;
            info.name = mtxtUser.Text;
            ClassAccount account = new ClassAccount();
            account._userName = mtxtUser.Text;
            account._password = mtxtPassword.Text;

            if (account.login() == true)
            {
                account.insertLog();
                FrmMenuP menu = new FrmMenuP(info);
                menu.Show();
                this.Hide();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "The Username or Password not right", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
    
}
