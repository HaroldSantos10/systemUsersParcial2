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
    public partial class FrmUsersProject : MetroForm
    {
        public FrmUsersProject()
        {
            InitializeComponent();
        }

        private void FrmUsersProject_Load(object sender, EventArgs e)
        {
            metroComboBox1.Items.Add("Harold Enoc Santos Morillo");
            metroComboBox1.Items.Add("Meylin Nohely Reyes Medina");
            metroComboBox1.Items.Add("Fátima del Carmen Ayala Santos");
            metroComboBox1.Items.Add("Maira Liseth Ramos Parada");

         
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void clearDataGridView()
        {
            dgvProjects.Columns.Clear();
            dgvProjects.Rows.Clear();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
