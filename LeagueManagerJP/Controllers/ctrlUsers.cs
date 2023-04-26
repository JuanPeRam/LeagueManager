using LeagueManagerJP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Perretes.MySQL;

namespace LeagueManagerJP.Controllers
{
    internal class ctrlUsers
    {
        public static User logIn(string username, string password)
        {
            String query = "SELECT cast(aes_decrypt(UserPassword, 'admnpd12') as char) = '" + password + "' FROM Users WHERE UserName LIKE '" + username + "'";
            Console.WriteLine(query);
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            if (dt.Rows.Count <= 0) return null;
            foreach (DataRow row in dt.Rows)
            {
                if ((Int64)row[0] == 0)
                {
                    return null;
                }
            }
            User user = new User();
            query = "SELECT ID_User, UserName, Email, UserType FROM Users WHERE UserName LIKE '" + username + "'";
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

        public static BindingSource readUsers(String type)
        {
            String query = "SELECT ID_User, UserName, Email, UserType FROM Users";
            if (type != null)
            {
                query += " WHERE UserType = '" + type + "'";
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
                user.Type = (string)row["UserType"];
                bsUsers.Add(user);
            }
            return bsUsers;
        }
    }

    
}
