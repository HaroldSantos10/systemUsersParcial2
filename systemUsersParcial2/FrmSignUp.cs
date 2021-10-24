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
    public partial class FrmSignUp : MetroForm
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            bool filled = validatingTextbox();
            if (mtxtPassword.Text != mtxtConfirm.Text || filled == false)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Password mismatch", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClassAccount account = new ClassAccount();

                account._firstName = mtxtFirstName.Text;
                account._lastName = mtxtLastName.Text;
                account._email = mtxtEmail.Text;
                account._registerDate = DateTime.Now.ToString("dd.MM.yyyy");
                account._userName = mtxtUser.Text;
                account._password = mtxtPassword.Text;
                account.registerUser();
                MetroFramework.MetroMessageBox.Show(this,
                    "User registration", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin login = new FrmLogin();
                login.Show();
            }

        }

        public Boolean validatingTextbox()
        {
            bool full= true;
            if (mtxtFirstName.Text == "")
            {
                mtxtFirstName.Focus();
                errorProvider1.SetError(mtxtFirstName, "First Name is required");
                full = false;
            }
            else if (mtxtLastName.Text == "")
            {
                mtxtLastName.Focus();
                errorProvider1.SetError(mtxtLastName, "Last Name is required");
                full = false;
            }
            else if (mtxtEmail.Text == "")
            {
                mtxtEmail.Focus();
                errorProvider1.SetError(mtxtEmail, "Email is required");
                full = false;
            }
            else if (mtxtUser.Text == "")
            {
                mtxtUser.Focus();
                errorProvider1.SetError(mtxtUser, "User Name is required");
                full = false;
            }
            else if (mtxtPassword.Text == "")
            {
                mtxtPassword.Focus();
                errorProvider1.SetError(mtxtPassword, "Password is required");
                full = false;
            }
            else if (mtxtConfirm.Text == "")
            {
                mtxtConfirm.Focus();
                errorProvider1.SetError(mtxtConfirm, "Password and confirm password does not match");
                full = false;
            }

            return full;
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();

        }

        private void FrmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
