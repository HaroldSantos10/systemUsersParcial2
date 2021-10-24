using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace systemUsersParcial2
{
    class fatima
    {
        Connection con = new Connection();
        Crud crud = new Crud();
        public int _clienteId { get; set; }
        public string _names { get; set; }
        public string _address { get; set; }
        public string _telephone { get; set; }



        //metodo para retornar los registros de la tabla 
        public MySqlDataReader getAllFatima()// se ve admin
        {
            string query = "SELECT clienteId,names,address,telephone FROM fatima";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }


    }
}
