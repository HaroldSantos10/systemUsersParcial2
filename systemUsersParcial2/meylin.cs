using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace systemUsersParcial2
{
    class meylin
    {
        Connection con = new Connection();
        Crud crud = new Crud();
        public int _figuraid { get; set; }
        public string _nombre { get; set; }
        public string _angulos { get; set; }
        public string _lados { get; set; }



        //metodo para retornar los registros de la tabla 
        public MySqlDataReader getAllMeylin()// se ve admin
        {
            string query = "SELECT figuraid,nombre,angulos,lados FROM meylin";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }
    }
}
