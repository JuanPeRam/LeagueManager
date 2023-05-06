using LeagueManagerJP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL;
using LeagueManagerJP.Forms.ControlForms;
using System.CodeDom.Compiler;
using MySql.Data.MySqlClient;

namespace LeagueManagerJP.Controllers
{
    internal class ctrlGames
    {
        public static BindingSource readGames(Competition competition, string condition)
        {
            String query = "SELECT ID_Game, ID_Referee, Home_Team, Away_Team, ID_Competition, Matchday, Game_Date, Played FROM games WHERE  ID_Competition = "+competition.Id+" "+condition;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Game> lstGames = new ObservableCollection<Game>();
            BindingSource bsGames = new BindingSource { DataSource = lstGames };
            foreach (DataRow row in dt.Rows)
            {
                Game game = new Game();
                game.competition = competition;
                game.Id = (int)row["ID_Game"];
                game.matchDay = (string)row["Matchday"];
                game.homeTeam = new Team();
                game.homeTeam.Id = (int)row["Home_Team"];
                game.homeTeam.Name = ctrlTeams.readTeamName(game.homeTeam.Id);
                game.awayTeam = new Team();
                game.awayTeam.Id = (int)row["Away_Team"];
                game.awayTeam.Name = ctrlTeams.readTeamName(game.awayTeam.Id);
                game.isPlayed = row["Played"].ToString() == "1";
                game.GameDate = (DateTime)Convert.ToDateTime(row["Game_Date"]);
                bsGames.Add(game);
            }
            return bsGames;
        }

        public static BindingSource readMatchdays(Competition competition) 
        {
            String query = "SELECT DISTINCT Matchday FROM games where ID_Competition = "+competition.Id;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<string> lstMd = new ObservableCollection<string>();
            BindingSource bsMatchDays = new BindingSource { DataSource = lstMd };
            string value;
            foreach (DataRow row in dt.Rows)
            {
                value = (string)row[0];
                lstMd.Add(value);
            }
            return bsMatchDays;
        }


        public static bool insertGames(List<Game> lstGames)
        {
            String query = "";
            int res;
            connMySQL con = new connMySQL();
            res = con.AbrirTransaccion();
            if(res == -1)
            {
                return false;
            }
            foreach(Game game in lstGames)
            {
                if(game.homeTeam.Name != "G" && game.awayTeam.Name!= "G")
                {
                    query = "INSERT INTO games VALUES (null,null," + game.homeTeam.Id + "," + game.awayTeam.Id + "," + game.competition.Id + ",'" + game.matchDay + "','"+game.GameDate.ToString("yyyy-MM-dd HH:mm:ss.fff") +"'," + (game.isPlayed ? 1 : 0) + ")";
                    res = con.EjecutarSQL_EnTransac(query);
                    if (res == -1)
                    {
                        return false;
                    }
                }
            }
            res = con.CerrarTransaccionCorrecta();
            if(res == -1)
            {
                return false;
            }
            return true;
        }

        public static bool deleteGames(int competitionID)
        {
            String query = "DELETE FROM games WHERE ID_Competition = " + competitionID;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool closeGame(int id)
        {
            String query = "UPDATE games SET Played = 1 WHERE ID_Game = " + id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool setReferee(int id, User referee)
        {
            String query = "UPDATE games SET ID_Referee = "+referee.Id+" WHERE ID_Game = " + id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool areAllGamesPlayed(Competition competition)
        {
            String query = "SELECT Played FROM games WHERE ID_Competition = " + competition.Id+" AND Played  =0";
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            return !(dt.Rows.Count > 0);
        }

        public static Team getWinner(Game game)
        {
            String query = "SELECT SUM(Goals) " +
                "FROM reports  " +
                "WHERE ID_Game = "+game.Id+" AND " +
                "ID_Player IN " +
                "(SELECT ID_Player " +
                "FROM teamplayers " +
                "WHERE ID_Team = " +
                game.homeTeam.Id+" AND " +
                "ID_Period IN " +
                "(SELECT ID_Period " +
                "FROM periods " +
                "WHERE isnull(End_Date) OR End_Date < '"+game.GameDate.ToString("yyyy-MM-dd HH:mm:ss.fff") +"'));";
            int goalsHome = 0;
            int goalsAway = 0;
            DataTable dtHome = connMySQL.ObtenerDatosSQL(query);
            if (dtHome.Rows.Count != 0)
            {
                foreach(DataRow dr in dtHome.Rows)
                {
                    goalsHome = int.Parse(dr[0].ToString());
                }
            }
            query = "SELECT SUM(Goals) " +
                "FROM reports  " +
                "WHERE ID_Game = " + game.Id + " AND " +
                "ID_Player IN " +
                "(SELECT ID_Player " +
                "FROM teamplayers " +
                "WHERE ID_Team = " +
                game.awayTeam.Id + " AND " +
                "ID_Period IN " +
                "(SELECT ID_Period " +
                "FROM periods " +
                "WHERE isnull(End_Date) OR End_Date < '" + game.GameDate.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'));";
            DataTable dtAway = connMySQL.ObtenerDatosSQL(query);
            if (dtAway.Rows.Count != 0)
            {
                foreach (DataRow dr in dtAway.Rows)
                {
                    goalsAway = int.Parse(dr[0].ToString());
                }
            }
            return (goalsHome > goalsAway ? game.homeTeam : game.awayTeam);
        }
    }
}
