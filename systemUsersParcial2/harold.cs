﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace systemUsersParcial2
{
    class harold
    {
        Connection con = new Connection();
        Crud crud = new Crud();
        public int _idTv { get; set; }
        public string _marca { get; set; }
        public string _modelo { get; set; }
        public string _color { get; set; }
        public int _size { get; set; }
        public string _year { get; set; }


        //metodo para retornar los registros de la tabla 
        public MySqlDataReader getAllHarold()// se ve admin
        {
            string query = "SELECT tvId,marca,modelo,color,size,year FROM televisor";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

    }
}
