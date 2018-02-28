using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerreraBJ
{
    public partial class Crear_adopcion : Form
    {
        string idd, nomd,sexo,raza;
        DataTable dt = new DataTable();
        public Crear_adopcion()
        {
            InitializeComponent();
        }

        private void Crear_adopcion_Load(object sender, EventArgs e)
        {
            id.Text = Consultas.contar("adopcion", "ID").ToString();
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dueño.DisplayMember = "COMPLETO";
            dueño.ValueMember = "COMPLETO";
            dueño.DataSource = Consultas.buscar("duenio");
            mascota.DisplayMember = "COMPLETO";
            mascota.ValueMember = "COMPLETO";
            mascota.DataSource = Consultas.buscarColum("mascotas", "Rescatado", "ESTATUS");
        }

        private void mascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(mascota.Text))
            {
                dt = Consultas.buscarFila("mascotas", "ID", mascota.Text);
                animal.Text = dt.Rows[0][1].ToString();
                edad.Text = dt.Rows[0][4].ToString();
                razgos.Text = dt.Rows[0][6].ToString();
                sexo = dt.Rows[0][3].ToString();
                raza = dt.Rows[0][5].ToString();
                nombre.Text = dt.Rows[0][2].ToString();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void acept_Click(object sender, EventArgs e)
        {
            int a;
            if (!string.IsNullOrEmpty(dueño.Text) && !string.IsNullOrEmpty(mascota.Text) && !string.IsNullOrEmpty(nombre.Text))
            {
                if (int.TryParse(nombre.Text, out a))
                {
                    MessageBox.Show("No numeros en el nombre");
                }
                else
                {
                    dt = Consultas.buscarFila("duenio", "COMPLETO", dueño.Text);
                    idd = dt.Rows[0][0].ToString();
                    nomd = dt.Rows[0][1].ToString();
                    Consultas.crearAdopcion(idd, nomd, mascota.Text, nombre.Text, fecha.Text);
                    Consultas.crearRelacion(idd, mascota.Text); 
                    string completo=mascota.Text + " : " + nombre.Text + " | " + dueño.Text;
                    Consultas.actualizar_Mascota(mascota.Text, animal.Text, nombre.Text, sexo, edad.Text, razgos.Text, dueño.Text,completo,raza);
                    Consultas.actualizar_dato("mascotas", "ESTATUS", "Adoptado", mascota.Text, "ID");
                    this.Hide();             
                }
                    
            }
            else MessageBox.Show("Llene todo los campos");
        }
    }
}
