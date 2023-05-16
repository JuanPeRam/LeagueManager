using LeagueManagerJP.Forms.ControlForms;
using LeagueManagerJP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL;

namespace LeagueManagerJP.Controllers
{
    internal class ctrlPlayers
    {
        public static BindingSource readAllPlayers()
        {
            String query = "SELECT p.ID_Player, Player_Name, Age, Position, Nacionality, Number " +
                "FROM players p ";
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Player> lstPlayers = new ObservableCollection<Player>();
            BindingSource bsPlayers = new BindingSource { DataSource = lstPlayers };
            foreach (DataRow row in dt.Rows)
            {
                Player player = new Player();
                player.Id = (int)row["ID_Player"];
                player.Name = (string)row["Player_Name"];
                player.team = readCurrentTeam(player.Id);
                player.Age = (int)row["Age"];
                player.Position = (string)row["Position"];
                player.Nacionality = (string)row["Nacionality"];
                player.Number = (int)row["Number"];
                bsPlayers.Add(player);
            }
            return bsPlayers;
        }
        public static Team readCurrentTeam(int id_player)
        {
            String query = "SELECT t.ID_Team, Team_Name " +
                "from teams t, teamplayers tp  " +
                "WHERE t.ID_Team = tp.ID_Team AND ID_Player = " + id_player + " " +
                "AND " + ctrlPeriods.noEndDate;
            DataTable dtTeam = connMySQL.ObtenerDatosSQL(query);
            if (dtTeam.Rows.Count > 0)
            {
                Team team = new Team();
                foreach (DataRow row in dtTeam.Rows)
                {
                    
                    team.Id = (int)row[0];
                    team.Name = (string)row[1];
                }
                return team;
            }
            return null;
        }
        public static BindingSource readPlayersByTeam(Team team)
        {
            String query = "SELECT p.ID_Player, Player_Name, Age, Position, Nacionality, Number FROM players p INNER JOIN teamplayers tp ON p.ID_Player = tp.ID_Player  WHERE ID_Team = " + team.Id + " AND "+ctrlPeriods.noEndDate;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Player> lstPlayers = new ObservableCollection<Player>();
            BindingSource bsPlayers = new BindingSource { DataSource = lstPlayers };
            foreach (DataRow row in dt.Rows)
            {
                Player player = new Player();
                player.Id = (int)row["ID_Player"];
                player.Name = (string)row["Player_Name"];
                player.team = team;
                player.Age = (int)row["Age"];
                player.Position = (string)row["Position"];
                player.Nacionality = (string)row["Nacionality"];
                player.Number = (int)row["Number"];
                bsPlayers.Add(player);
            }
            return bsPlayers;
        }

        public static BindingSource readNonTeamPlayers()
        {
            String query = "SELECT ID_Player, Player_Name, Age, Position, Nacionality, Number FROM players  " +
                "WHERE ID_Player NOT IN (SELECT ID_Player FROM teamplayers WHERE "+ctrlPeriods.noEndDate+")";
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Player> lstPlayers = new ObservableCollection<Player>();
            BindingSource bsPlayers = new BindingSource { DataSource = lstPlayers };
            foreach (DataRow row in dt.Rows)
            {
                Player player = new Player();
                player.Id = (int)row["ID_Player"];
                player.Name = (string)row["Player_Name"];
                player.team = null;
                player.Age = (int)row["Age"];
                player.Position = (string)row["Position"];
                player.Nacionality = (string)row["Nacionality"];
                player.Number = (int)row["Number"];
                bsPlayers.Add(player);
            }
            return bsPlayers;
        }

        public static bool insertPlayer(Player player)
        {
            String query = "INSERT INTO players VALUES (null, " + player.Number + "," +
                "'" + player.Name + "'," + player.Age + ",'" + player.Position + "','" + player.Nacionality + "')";
            if (player.team == null)
            {
                connMySQL con = new connMySQL();
                int res = con.AbrirTransaccion();
                if (res == -1) return false;
                res = con.EjecutarSQL_EnTransac(query);
                if (res == -1) return false;
                int id_player = getLastPlayerInTrans(con);
                if (id_player == 0)
                {
                    con.CerrarTransaccionErronea();
                    return false;
                }
                player.Id = id_player;
                res = con.CerrarTransaccionCorrecta();
                if (res == -1) return false;
                return true;
            }
            else
            {
                connMySQL con = new connMySQL();
                int res = con.AbrirTransaccion();
                if (res == -1) return false;
                res = con.EjecutarSQL_EnTransac(query);
                if (res == -1) return false;
                int id_period = ctrlPeriods.insertPeriodinTrans(con, null,false);
                if (id_period == 0)
                {
                    con.CerrarTransaccionErronea();
                    return false;
                }
                int id_player = getLastPlayerInTrans(con);
                if(id_player == 0)
                {
                    con.CerrarTransaccionErronea();
                    return false;
                }
                player.Id = id_player;
                query = "INSERT INTO teamplayers VALUES (" + player.team.Id + "," + player.Id + "," + id_period + ")";
                res = con.EjecutarSQL_EnTransac(query);
                if (res == -1) return false;
                res = con.CerrarTransaccionCorrecta();
                if (res == -1) return false;
                return true;
            }

        }

        private static int getLastPlayerInTrans(connMySQL con)
        {
            String query = "SELECT MAX(ID_Player) FROM players";
            int id_player = 0;
            MySqlDataReader reader = con.ObtenerDatosSQL_EnTransac(query);
            while (reader.Read())
            {
                id_player = reader.GetInt32(0);
            }
            reader.Close();
            return id_player;
        }

        public static bool modifyPlayer(Player player)
        {
            String query = "UPDATE players SET Player_Name = '" + player.Name + "', Age = " + player.Age + "," +
                "Position = '" + player.Position + "', Nacionality = '" + player.Nacionality + "', Number = " + player.Number + " WHERE ID_Player = " + player.Id + "";
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool signPlayer(Player player)
        {
            connMySQL con = new connMySQL();
            int res = con.AbrirTransaccion();
            if (res == -1) return false;
            int id_period = ctrlPeriods.insertPeriodinTrans(con, null,false);
            if (id_period == 0)
            {
                con.CerrarTransaccionErronea();
                return false;
            }
            String query = "INSERT INTO teamplayers VALUES (" + player.team.Id + "," + player.Id + "," + id_period + ")";
            if (con.EjecutarSQL_EnTransac(query) == -1) 
            {
                return false;
            }
            else
            {
                res = con.CerrarTransaccionCorrecta();
                if (res == -1) return false;
                return true;
            }
            
        }

        public static bool deletePlayer(Player player)
        {
            //Checking if the player has played a game of a Date greater than now
            String checkquery = "SELECT NOW() < (SELECT MAX(Game_Date) FROM games WHERE ID_Game IN (SELECT ID_Game FROM reports WHERE ID_Player = "+player.Id+"))";
            DataTable dtcheck = connMySQL.ObtenerDatosSQL(checkquery);
            foreach(DataRow row in dtcheck.Rows)
            {
                if (row[0].ToString() == "1") return false;
            }
            //Getting the Period Id to end the "contract"
            String query = "SELECT ID_Period FROM teamplayers WHERE ID_Player = "+player.Id+" AND ID_Team = "+player.team.Id+" AND "+ctrlPeriods.noEndDate;
            DataTable dtPeriod = connMySQL.ObtenerDatosSQL(query);
            if (dtPeriod.Rows.Count > 0)
            {
                int id_period = 0;
                foreach (DataRow row in dtPeriod.Rows)
                {
                    id_period = (int)row[0];
                }
                if (ctrlPeriods.endPeriod(id_period)) return true;
                else return false;
            }
            else return false;

        }
    }
}
