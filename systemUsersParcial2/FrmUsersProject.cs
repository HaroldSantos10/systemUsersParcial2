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
            if (metroComboBox1.SelectedIndex == 0)
            {
                //llenar Harold
                harold clas = new harold();

                clearDataGridView();

                dgvProjects.Columns.Add("idTv", "ID");
                dgvProjects.Columns.Add("marca", "MARK");
                dgvProjects.Columns.Add("modelo", "MODEL");
                dgvProjects.Columns.Add("color", "COLOR");
                dgvProjects.Columns.Add("size", "SIZE");
                dgvProjects.Columns.Add("year", "YEAR");

                //llamado al medoto

                MySqlDataReader dataReader = clas.getAllHarold();

                //leer el resultado y mostrarlo en el datagridview
                while (dataReader.Read())
                {
                    dgvProjects.Rows.Add(
                            dataReader.GetValue(0),
                            dataReader.GetValue(1),
                            dataReader.GetValue(2),
                            dataReader.GetValue(3),
                            dataReader.GetValue(4),
                            dataReader.GetValue(5)
                           );
                }
            }
            else if (metroComboBox1.SelectedIndex == 1)
            {
                meylin mey = new meylin();

                clearDataGridView();

                dgvProjects.Columns.Add("figuraid", "ID FIGURA");
                dgvProjects.Columns.Add("nombre", "NAME");
                dgvProjects.Columns.Add("angulos", "ANGULO");
                dgvProjects.Columns.Add("lados", "SIDES");


                //llamado al medoto

                MySqlDataReader reader = mey.getAllMeylin();

                //leer el resultado y mostrarlo en el datagridview
                while (reader.Read())
                {
                    dgvProjects.Rows.Add(
                            reader.GetValue(0),
                            reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3)
                           );
                }
            }

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
