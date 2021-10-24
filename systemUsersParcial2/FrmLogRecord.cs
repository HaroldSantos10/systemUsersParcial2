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
    public partial class FrmLogRecord : MetroForm
    {
        public FrmLogRecord()
        {
            InitializeComponent();
        }

        private void FrmLogRecord_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        public void fillDataGridView()
        {

            ClassAccount account = new ClassAccount();

            clearDataGridView();

            dgvLogRecord.Columns.Add("codLog", "LOG CODE");
            dgvLogRecord.Columns.Add("userName", "USER NAME");
            dgvLogRecord.Columns.Add("timeLoggedin", "TIME LOG");
            

            //llamado al medoto getBooks() de la clase Book

            MySqlDataReader dataReader = account.getLog();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dgvLogRecord.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                       );
            }

        }
        public void clearDataGridView()
        {
            dgvLogRecord.Columns.Clear();
            dgvLogRecord.Rows.Clear();
        }

    }
}
