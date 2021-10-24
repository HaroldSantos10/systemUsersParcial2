using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace systemUsersParcial2
{
    class ClassAccount
    {
        Connection con = new Connection();
        Crud crud = new Crud();
        public int _codUser { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _email { get; set; }
        public string _registerDate { get; set; }
        public string _userName { get; set; }
        public string _password { get; set; }
        //public string _timeLoggedin { get; set; }

        public MySqlDataReader getAll()//no se ve admin
        {
            string query = "SELECT * from account WHERE codUser<>1";
            //llamado al metodo select
            return crud.select(query);
        }

        

        //metodo para retornar los registros de la tabla 
        public MySqlDataReader getAllUsers()// se ve admin
        {
            string query = "SELECT codUser,firstName,lastName,email,registerDate,userName,password FROM account";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar un usuario nuevo en la bd
        public Boolean registerUser()
        {
            
            string query = "INSERT INTO account(firstName, lastName, email, registerDate, userName, password)" +
                "VALUES ('" + _firstName + "', '" + _lastName + "', '" + _email + "'" +
                ", '" + _registerDate + "', '" + _userName + "', '" + _password + "')";
            crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud

            return true;
        }

        public Boolean login()
        {
            string query = "SELECT * FROM account WHERE userName= '" + _userName + "' AND password= '" + _password + "'";
            if (crud.select(query).HasRows)
            {
                return true;
            }
            return false;
        }
        
        public void insertLog()
        {
            string insertLog = "INSERT INTO userlog(userName, timeLoggedin) VALUES ('" + _userName + "','" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "')";
            crud.executeQuery(insertLog);
        }

        public MySqlDataReader getByID()
        {
            string query = "SELECT * from account WHERE userName= '" +_userName+"' ";
            //llenado al metodo select de la clase crud
            return crud.select(query);
        }

        public MySqlDataReader getLog()
        {
            string query = "SELECT * from userlog";
            //llamado al metodo select de la clase crud
            return crud.select(query);
        }

        public MySqlDataReader getLogWhithoutAdmin()
        {
            string query = "SELECT * from userlog WHERE userName <> 'Admin'";
            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        

    }
}
