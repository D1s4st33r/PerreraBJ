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
    public partial class Dueños : Form
    {
        DataTable dt = new DataTable();
        public Dueños()
        {
            InitializeComponent();
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(buscar.Text))
            {
                opciones.DataSource = null;
                opciones.DisplayMember = "COMPLETO";
                opciones.ValueMember = "COMPLETO";
                opciones.DataSource = Consultas.buscarxRef("duenio", "COMPLETO", buscar.Text);
            }
            else
            {
                opciones.DataSource = null;
                opciones.DisplayMember = "COMPLETO";
                opciones.ValueMember = "COMPLETO";
                opciones.DataSource = Consultas.buscar("duenio");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(opciones.Text))
            {
                dt = Consultas.buscarFila("duenio", "COMPLETO", opciones.Text);
                id.Text = dt.Rows[0][0].ToString();
                nombre.Text = dt.Rows[0][1].ToString();                
                aparterno.Text = dt.Rows[0][2].ToString();
                amaterno.Text = dt.Rows[0][3].ToString();
                string sex = dt.Rows[0][4].ToString();
                if (sex == "Masculino") { women.Checked = false; men.Checked = true; }
                else { men.Checked = false; women.Checked = true; }
                nacimineto.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
                direccion.Text = dt.Rows[0][6].ToString();
                telefono.Text = dt.Rows[0][7].ToString();
                fecha.Text = dt.Rows[0][8].ToString();
                ciudad.Text = dt.Rows[0][13].ToString();
           }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Crear_dueño nuevo = new Crear_dueño();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(opciones.Text))
            {
                string sex;
                long a;
                if (men.Checked == true) sex = "Masculino";
                else sex = "Femenino";
                if (!string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(aparterno.Text) && !string.IsNullOrEmpty(amaterno.Text) && !string.IsNullOrEmpty(telefono.Text) && !string.IsNullOrEmpty(direccion.Text))
                {
                    if (telefono.Text.Length == 10 && long.TryParse(telefono.Text, out a))
                    {
                        dt = Consultas.buscarDato("IDDUENIO", "duenio", opciones.Text, "COMPLETO");
                        string completo = nombre.Text + " " + aparterno.Text + " " + amaterno.Text + " :" + dt.Rows[0][0];
                        if (long.TryParse(nombre.Text, out a) && long.TryParse(aparterno.Text, out a) && long.TryParse(amaterno.Text, out a))
                        {
                            MessageBox.Show("No se permiten numeros en algunos campos");
                        }
                        else
                        {
                            Consultas.actualizar_duenio(nombre.Text, aparterno.Text, amaterno.Text, sex, direccion.Text, telefono.Text, nacimineto.Value.ToString("dd/MM/yyyy"), completo, opciones.Text,ciudad.Text);                          
                        }
                    }
                    else MessageBox.Show("El telefono debe contener 10 digitos");
                }
                else MessageBox.Show("Llene todo los campos");
            }
        }

        private void Dueños_Load(object sender, EventArgs e)
        {
            opciones.DisplayMember = "COMPLETO";
            opciones.ValueMember = "COMPLETO";
            opciones.DataSource = Consultas.buscar("duenio");
            ciudad.DisplayMember = "NOMBRE";
            ciudad.ValueMember = "NOMBRE";
            ciudad.DataSource = Consultas.buscar("ciudades");
        }

        private void Dueños_Activated(object sender, EventArgs e)
        {
            opciones.DataSource = null;
            opciones.DisplayMember = "COMPLETO";
            opciones.ValueMember = "COMPLETO";
            opciones.DataSource = Consultas.buscar("duenio");
        }
    }
    }

