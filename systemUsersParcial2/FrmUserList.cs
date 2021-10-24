using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Forms;

namespace systemUsersParcial2
{
    public partial class FrmUserList : MetroForm
    {
        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            ClassAccount account = new ClassAccount();

            clearDataGridView();

            dgvUserList.Columns.Add("codUser", "USER CODE");
            dgvUserList.Columns.Add("firstName", "FIRST NAME");
            dgvUserList.Columns.Add("lastName", "LAST NAME");
            dgvUserList.Columns.Add("email", "E-MAIL");
            dgvUserList.Columns.Add("registerDate", "REGISTER DATE");
            dgvUserList.Columns.Add("userName", "USER NAME");
            dgvUserList.Columns.Add("password", "PASSWORD");

            
            //llamado al medoto getBooks() de la clase Book

            MySqlDataReader dataReader = account.getAll();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dgvUserList.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6)
                        //dataReader.GetValue(7)
                       );
            }
        }
        public void clearDataGridView()
        {
            dgvUserList.Columns.Clear();
            dgvUserList.Rows.Clear();
        }

    }
}
