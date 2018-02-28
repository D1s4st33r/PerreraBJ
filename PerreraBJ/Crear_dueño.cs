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
    public partial class Crear_dueño : Form
    {
        public Crear_dueño()
        {
            InitializeComponent();
        }

        private void Crear_dueño_Load(object sender, EventArgs e)
        {
            id.Text = (10000 + Consultas.contar("duenio", "ID")).ToString();
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ciudad.DisplayMember = "NOMBRE";
            ciudad.ValueMember = "NOMBRE";
            ciudad.DataSource = Consultas.buscar("ciudades");
        }

        private void acept_Click(object sender, EventArgs e)
        {
            long ce;
            string sex;
            int a;
            
            if (men.Checked == true) sex = "Masculino";
            else sex = "Femenino";
            if (!string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(aparterno.Text) && !string.IsNullOrEmpty(amaterno.Text) && !string.IsNullOrEmpty(telefono.Text) && !string.IsNullOrEmpty(direccion.Text))
            {
                if (telefono.Text.Length == 10 && long.TryParse(telefono.Text, out ce))
                {
                    string refe = DateTime.Now.ToString("yyyy");
                    if (int.TryParse(refe, out a) && a >= 1999)
                    {
                        string completo = nombre.Text + " " + aparterno.Text + " " + amaterno.Text + " :" + id.Text;
                        if (long.TryParse(nombre.Text, out ce) && long.TryParse(aparterno.Text, out ce) && long.TryParse(amaterno.Text, out ce))
                        {
                            MessageBox.Show("No se permiten numeros en algunos campos");
                        }
                        else
                        {
                            Consultas.crearDuenio(id.Text, nombre.Text, aparterno.Text, amaterno.Text, sex, direccion.Text, telefono.Text, nacimineto.Value.ToString("dd/MM/yyyy"), fecha.Text, completo, ciudad.Text);
                            this.Hide();
                        }
                    }
                    else MessageBox.Show("NO MENORES DE EDAD");
                }
                else MessageBox.Show("El telefono debe contener 10 digitos");
            }
            else MessageBox.Show("Llene todo los campos");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
