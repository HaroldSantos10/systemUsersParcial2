using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace systemUsersParcial2
{
    class maira
    {
        Connection con = new Connection();
        Crud crud = new Crud();
        public int _documentoid { get; set; }
        public string _titulo { get; set; }
        public string _contenido { get; set; }
        public string _fechapublicacion { get; set; }



        //metodo para retornar los registros de la tabla 
        public MySqlDataReader getAllMaira()// se ve admin
        {
            string query = "SELECT documentoid,titulo,contenido,fechapublicacion FROM maira";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

    }
}
