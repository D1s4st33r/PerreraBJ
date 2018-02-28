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
    public partial class Crear_rescate : Form
    {
        public Crear_rescate()
        {
            InitializeComponent();
        }

        private void Crear_rescate_Load(object sender, EventArgs e)
        {
            id.Text = (Consultas.contar("rescate", "ID")).ToString();
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dog_CheckedChanged(object sender, EventArgs e)
        {
            if (dog.Checked == true)
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Perro", "ANIMAL");
            }
            else
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Gato", "ANIMAL");
            }
        }

        private void acept_Click(object sender, EventArgs e)
        {
            string sex, tipo;
            int a;
            if (men.Checked == true) sex = "Macho";
            else sex = "Hembra";
            if (dog.Checked == true) tipo = "Perro";
            else tipo = "Gato";
            if (!string.IsNullOrEmpty(raza.Text) && !string.IsNullOrEmpty(edad.Text) && !string.IsNullOrEmpty(razgos.Text) && !string.IsNullOrEmpty(condicion.Text) && !string.IsNullOrEmpty(lugar.Text)&& !string.IsNullOrEmpty(nombre.Text))
            {
                if (int.TryParse(nombre.Text, out a)) MessageBox.Show("No numeros en nombre");
                else
                {
                    if (int.TryParse(edad.Text, out a))
                    {
                        string ede = Consultas.contar("mascotas", "ID").ToString();
                        string completo = id.Text + " : " + nombre.Text;
                        string vida = (edad.Text + " " + tiempo.Text);
                        Consultas.crearRescate(tipo, raza.Text, sex, razgos.Text, condicion.Text, lugar.Text, fecha.Text, vida);
                        Consultas.crearMascota(null, tipo, nombre.Text, sex, vida, fecha.Text, razgos.Text, null, completo, raza.Text, "Rescatado");
                        this.Hide();

                    }
                    else MessageBox.Show("Solo numeros en la edad");
                }
            }
            else MessageBox.Show("Llene todo los campos");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
