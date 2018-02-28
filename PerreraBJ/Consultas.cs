using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerreraBJ
{
    class Consultas
    {
        //BUSQUEDA completa
        public static DataTable buscar(string tabla)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT * FROM " + tabla);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //BUSQUEDA DE FILA
        public static DataTable buscarFila(string tabla, string colum, string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT * FROM " + tabla + " WHERE " + colum + "='{0}';", dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //BUSQUEDA DE DATO ESPECIFICO
        public static DataTable buscarDato(string columna, string tabla, string dato, string columnaref)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT " + columna + " FROM " + tabla + " WHERE " + columnaref + "='{0}';", dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Dispose();
            return dt;
        }

        //BUSQUEDA DE COLUMNA ESPECIFICA
        public static DataTable buscarColum(string tabla, string dato, string referencia)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT * FROM " + tabla + " WHERE " + referencia + "='{0}';", dato);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //BUSQUEDA CON UN LIKE
        public static DataTable buscarxRef(string tabla,string referencia,string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT * FROM " + tabla+" WHERE "+referencia+" LIKE ('%"+dato+"%');" );
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //BUSQUEDA CON 2 LIKE
        public static DataTable buscarxRef2(string tabla, string referencia, string dato)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion = Conexion.Conectar();
            string query = string.Format("SELECT * FROM " + tabla + " WHERE " + referencia + " LIKE ('%" + dato + "%') OR IDDUENIO LIKE (%"+dato+"%);");
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            conexion.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //CONSULTA PARA CONTAR EL TOTAL DE FILAS
        public static int contar(string tabla, string colum)
        {
            string query = string.Format("SELECT count(" + colum + ") from " + tabla + ";");

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());

            int respuesta = (Convert.ToInt32(comando.ExecuteScalar()));
            return respuesta + 1;
        }

        //*********************************************************************************************
        //*********************************************************************************************

        //CREAR UN DUEÑO
        public static void crearDuenio(string id,string nom, string apa, string ama, string sexo, string dir, string tel, string fechaN,string fechaR,string comp,string ciudad)
        {
            string query = string.Format("INSERT into duenio (IDDUENIO,NOMBRE,APATERNO,AMATERNO,GENERO,FNACIMIENTO,DIRECCION,TELEFONO,FREGISTRO,ESTATUS,ADOPTO,COMPLETO,CIUDAD) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}');", id, nom, apa, ama, sexo,fechaN,dir,tel,fechaR,"Activo",0,comp,ciudad);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("DUEÑO REGISTRADO");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //ACTUALIZAR DUEÑO
        public static void actualizar_duenio(string nom, string apa, string ama, string sexo, string dir, string tel, string fechaN, string completo, string viejo,string ciudad)
        {
            
            string query = string.Format("UPDATE duenio SET NOMBRE = '{0}',APATERNO = '{1}',AMATERNO = '{2}',GENERO = '{3}',FNACIMIENTO = '{4}',DIRECCION = '{5}',TELEFONO = '{6}',COMPLETO = '{7}',CIUDAD= '{8}'  WHERE COMPLETO= '{9}';", nom,apa,ama,sexo,fechaN,dir,tel,completo,ciudad, viejo);
            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("DUEÑO ACTUALIZADO");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        //CONSULTA PARA ACTUALIZAR UN DATO
        public static void actualizar_dato(string tabla, string colum, string nuevo, string viejo, string columaref)
        {
            string query = string.Format("update " + tabla + " set " + colum + " = '{0}' where " + columaref + "= '{1}';", nuevo, viejo);
            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Dato Actualizado");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        //*******************************************************************************************************
        //*******************************************************************************************************

        //CREAR MASCOTA

        public static void crearMascota(string id,string tipo, string nom,  string sexo, string edad, string fechaR, string razgo,string dueño,string completo,string raza,string estatus)
        {
            string query = string.Format("INSERT into mascotas (ID,TIPO,NOMBRE,SEXO,EDAD,RAZA,RAZGOS,DUENIO,FREGISTRO,COMPLETO,ESTATUS) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');", id, tipo, nom, sexo, edad, raza, razgo, dueño, fechaR, completo, estatus);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("MASCOTA REGISTRADA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        //ACTUALIZAR MASCOTA

        public static void actualizar_Mascota(string id,string tipo, string nom, string sexo, string edad, string razgo, string dueño, string completo, string raza)
        {
            string query = string.Format("UPDATE mascotas SET TIPO='{0}',NOMBRE='{1}',SEXO='{2}',EDAD='{3}',RAZA='{4}',RAZGOS='{5}',DUENIO='{6}',COMPLETO='{7}' WHERE ID='{8}';", tipo, nom, sexo, edad, raza, razgo, dueño, completo, id); 

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("MASCOTA ACTUALIZADA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //*************************************************************************************************************
        //*************************************************************************************************************

        //CREAR RELACION MASCOTA/DUEÑO
        public static void crearRelacion(string iddueño,string idmascota)
        {
            string query = string.Format("INSERT into detalle_relacion (IDDUENIO,IDMASCOTA) values ('{0}','{1}');", iddueño,idmascota);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Actualizar RELACION MASCOTA/DUEÑO
        public static void actualizar_Relacion(string iddueño, string idmascota)
        {
            string query = string.Format("UPDATE detalle_relacion SET IDDUENIO= '{0}' WHERE IDMASCOTA='{1}';", iddueño, idmascota);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //************************************************************************************
        //************************************************************************************

        //CREAR CARTILLA DE VACUNACION

        public static void crearVacuna(string id, string tabla,string mascota,string nombre)
        {
            string query = string.Format("INSERT into "+tabla+" ("+mascota+",NOMBRE) values ('{0}','{1}');", id,nombre);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //CONSULTA PARA ACTUALIZAR UN Vacunas
        public static void actualizar_vacuna(string mascota,string id,string v1,string v2,string v3,string v4, string v5,string v6,string v7)
        {
            string query;
            string perro=string.Format("UPDATE detalle_vacuna_perros SET PARVO = '{0}', PARVOCORONA = '{1}', TRIPLE = '{2}', QUINTUPLE = '{3}', SEXTUPLE = '{4}', RABIA = '{5}' WHERE IDPERRO = '{6}';", v1, v2, v3, v4, v5, v6, id);
            string gato = string.Format("UPDATE detalle_vacuna_gatos SET LEUCEMIA = '{0}', TRIPLE = '{1}', LEUCEMIA2 = '{2}', TRIPLE2 = '{3}', PIF = '{4}', RABIA = '{5}',PIF2= '{6}' WHERE IDGATO = '{7}';", v1, v2, v3, v4, v5, v6,v7, id);
            query = (mascota == "Perro") ? perro : gato;
            //string query= string.Format("UPDATE detalle_vacuna_perros SET PARVO = '{0}', PARVOCORONA = '{1}', TRIPLE = '{2}', QUINTUPLE = '{3}', SEXTUPLE = '{4}', RABIA = '{5}' WHERE IDPERRO = '{6}';", v1, v2, v3, v4, v5, v6, id);
            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cartilla registrada");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        //************************************************************************************
        //************************************************************************************

        //CREAR CARTILLA REGISTRO DE RESCATE
        public static void crearRescate(string anim,string raza,string sex,string cara,string condi,string lugar, string regis,string edad)
        {
            string query = string.Format("INSERT into rescate (ANIMAL,EDAD,RAZA,SEXO,CARACTE,CONDICIONES,LHALLAZGO,FREGISTRO) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", anim,edad,raza,sex,cara,condi,lugar,regis);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Rescate Registrado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //CREAR CARTILLA REGISTRO DE ADOPCION
        public static void crearAdopcion(string idduenio, string dueño, string idmascota, string mascota, string fregistro)
        {
            string query = string.Format("INSERT into adopcion (IDDUENIO,DUENIO,IDMASCOTA,MASCOTA,FREGISTRO) values ('{0}','{1}','{2}','{3}','{4}');", idduenio,dueño,idmascota,mascota,fregistro);

            MySqlCommand comando = new MySqlCommand(query, Conexion.Conectar());
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Adopcion Registrada");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
