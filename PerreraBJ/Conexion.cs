using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PerreraBJ
{
    class Conexion
    {
        public static MySqlConnection Conectar()
        {
            string servidor = "127.0.0.1";
            string BD = "perrera";
            string usuario = "root";
            string passwor = "";

            MySqlConnection conexion = new MySqlConnection("server=" + servidor + "; database= " + BD + "; Uid=" + usuario + "; pwd=" + passwor + ";");
            conexion.Open();
            return conexion;
        }
    }
}
