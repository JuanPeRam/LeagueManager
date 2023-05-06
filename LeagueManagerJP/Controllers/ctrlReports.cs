using LeagueManagerJP.Models;
using MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagerJP.Controllers
{
    public class ctrlReports
    {

        public static bool InsertReports(List<Report> reports)
        {
            connMySQL con = new connMySQL();
            int res = con.AbrirTransaccion();
            if (res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al abrir la transacción");
                return false;
            }
            String query = "";
            foreach (Report report in reports)
            {
                query = "INSERT INTO reports VALUES ("+report.player.Id+","+report.match.Id+","+report.goals+",'"+report.sanctions+"')";
                res = con.EjecutarSQL_EnTransac(query);
                if (res == -1)
                {
                    MessageBox.Show("Ha ocurrido un error en la inserción de datos");
                    return false;
                }
            }
            res = con.CerrarTransaccionCorrecta();
            if(res == -1)
            {
                MessageBox.Show("Ha ocurrido un error al cerrar la transacción");
                return false;
            }
            MessageBox.Show("Datos introducidos con éxito");
            return true;
        }
    }
}
