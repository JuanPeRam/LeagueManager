using LeagueManagerJP.Forms.ControlForms;
using LeagueManagerJP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL;

namespace LeagueManagerJP.Controllers
{
    internal class ctrlUsers
    {
        public static User logIn(string username, string password)
        {
            String query = "SELECT cast(aes_decrypt(UserPassword, 'admnpd12') as char) = '" + password + "' FROM users WHERE UserName LIKE '" + username + "'";
            Console.WriteLine(query);
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            if (dt.Rows.Count <= 0) return null;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == "0")
                {
                    return null;
                }
            }
            User user = new User();
            query = "SELECT ID_User, UserName, Email, NameType FROM users, userstype WHERE UserName LIKE '" + username + "' AND UserType = ID_UserType";
            dt = connMySQL.ObtenerDatosSQL(query);
            foreach (DataRow row in dt.Rows)
            {
                user.Id = (int)row[0];
                user.UserName = (String)row[1];
                user.Email = (String)row[2];
                user.Type = (String)row[3];
            }
            return user;
        }

        public static BindingSource readUsers(String condition)
        {
            String query = "SELECT ID_User, UserName, Email, NameType FROM users, userstype WHERE UserType = ID_UserType";
            if (condition != null)
            {
                query += " "+condition;
            }
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<User> lstUsers = new ObservableCollection<User>();
            BindingSource bsUsers = new BindingSource { DataSource = lstUsers };
            foreach (DataRow row in dt.Rows)
            {
                User user = new User();
                user.Id = (int)row["ID_User"];
                user.UserName = (string)row["UserName"];
                user.Email = (string)row["Email"];
                user.Type = (string)row["NameType"];
                bsUsers.Add(user);
            }
            return bsUsers;
        }

        public static BindingSource readNonTeamTrainers()
        {
            String condition = " AND UserType = 2 AND ID_User NOT IN (SELECT ID_User FROM teamsManager WHERE ID_Period IN (SELECT ID_Period from periods WHERE Start_Date < NOW() AND isnull(End_Date)) )";
            return readUsers(condition);
        }

        public static User readUser(int id)
        {
            string query = "SELECT ID_User, UserName, Email, NameType FROM users,userstype WHERE ID_User =" + id+ " AND UserType = ID_UserType";
            User user = new User();
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            foreach (DataRow row in dt.Rows)
            {
                user.Id = (int)row["ID_User"];
                user.UserName = (string)row["UserName"];
                user.Email = (string)row["Email"];
                user.Type = (string)row["NameType"];
            }
            return user;

        }

        public static void ModifyUser(User user)
        {
            String query = "UPDATE users SET UserName = '"+user.UserName+"', Email = '"+user.Email+"' WHERE ID_User = "+user.Id;
            connMySQL con = new connMySQL();
            int res = con.AbrirTransaccion();
            if(res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al abrir la transacción");
                return;
            }
            res = con.EjecutarSQL_EnTransac(query);
            if(res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al modificar los datos");
                return;
            }
            res = con.CerrarTransaccionCorrecta();
            if(res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al cerrar la transacción");
                return;
            }
            MessageBox.Show("Se han modificado los datos con éxito");
        }

        public static void InsertUser(User user, string password)
        {
            String query = "INSERT INTO users VALUES ( null,'"+user.UserName+"'" +
                ", aes_encrypt('"+password+"','admnpd12'), '"+user.Email+ "', (SELECT ID_UserType FROM userstype WHERE NameType = '"+user.Type+"'))";
            connMySQL con = new connMySQL();
            int res = con.AbrirTransaccion();
            if (res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al abrir la transacción");
                return;
            }
            res = con.EjecutarSQL_EnTransac(query);
            if (res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al insertar los datos");
                return;
            }
            
            query = "SELECT MAX(ID_User) FROM users";
            MySqlDataReader reader = con.ObtenerDatosSQL_EnTransac(query);
            if (reader != null)
            {
                while (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                }
                reader.Close();
            }
            res = con.CerrarTransaccionCorrecta();
            if (res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al cerrar la transacción");
                return;
            }
            MessageBox.Show("Se han insertado los datos con éxito");
        }

        public static void DeleteUser(int id)
        {
            String query = "DELETE FROM users WHERE ID_User = " + id;
            if(connMySQL.EjecutarSQL(query) == -1)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar los datos");
            }
            else
            {
                MessageBox.Show("Datos eliminados con éxito");
            }
        }
    }

    
}
