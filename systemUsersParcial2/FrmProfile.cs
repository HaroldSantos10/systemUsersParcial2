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
    public partial class FrmProfile : MetroForm
    {
        public FrmProfile(FrmMenuP.Names2 info)
        {
            InitializeComponent();
            labelName.Text = info.name2;
        }
        
        private void frmProfile_Load(object sender, EventArgs e)
        {
            //FrmProfile pro = new FrmProfile(Fr);
            //string name = pro.Text.ToString();

 
            ClassAccount account = new ClassAccount();
            account._userName = labelName.Text;
            
            MySqlDataReader dataReader = account.getByID();

            if (dataReader.Read() == true)
            {
                mlUserName.Text = dataReader["userName"].ToString();
                mlCompName.Text = dataReader["firstName"].ToString();
                mlEmail.Text = dataReader["email"].ToString();
                mlRegisDate.Text = dataReader["registerDate"].ToString();
            }
           
            
        }




        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
