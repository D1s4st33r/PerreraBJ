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
    public partial class Mascotas : Form
    {
        string tipo;
        DataTable dt = new DataTable();
        public Mascotas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id.Text))
            {
                if (tipo == "Perro")
                {
                    dt = Consultas.buscarFila("detalle_vacuna_perros", "IDPERRO", id.Text);
                    if (!string.IsNullOrEmpty(dt.Rows[0][1].ToString())) vacuna1.Checked = true; else vacuna1.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][2].ToString())) vacuna2.Checked = true; else vacuna2.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][3].ToString())) vacuna3.Checked = true; else vacuna3.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][4].ToString())) vacuna4.Checked = true; else vacuna4.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][5].ToString())) vacuna5.Checked = true; else vacuna5.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][6].ToString())) vacuna6.Checked = true; else vacuna6.Checked = false;
                }
                else
                {
                    dt = Consultas.buscarFila("detalle_vacuna_gatos", "IDGATO", id.Text);
                    if (!string.IsNullOrEmpty(dt.Rows[0][1].ToString())) vacuna1.Checked = true; else vacuna1.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][2].ToString())) vacuna2.Checked = true; else vacuna2.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][3].ToString())) vacuna3.Checked = true; else vacuna3.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][4].ToString())) vacuna4.Checked = true; else vacuna4.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][5].ToString())) vacuna5.Checked = true; else vacuna5.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][6].ToString())) vacuna6.Checked = true; else vacuna6.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0][7].ToString())) vacuna7.Checked = true; else vacuna7.Checked = false;
                }
            }
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            opciones.DisplayMember = "COMPLETO";
            opciones.ValueMember = "COMPLETO";
            opciones.DataSource = Consultas.buscar("mascotas");
            dueño.DisplayMember = "COMPLETO";
            dueño.ValueMember = "COMPLETO";
            dueño.DataSource = Consultas.buscar("duenio");
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(buscar.Text))
            {
                opciones.DataSource = null;
                opciones.DisplayMember = "COMPLETO";
                opciones.ValueMember = "COMPLETO";
                opciones.DataSource = Consultas.buscarxRef("mascotas", "COMPLETO", buscar.Text);
            }
            else
            {
                opciones.DataSource = null;
                opciones.DisplayMember = "COMPLETO";
                opciones.ValueMember = "COMPLETO";
                opciones.DataSource = Consultas.buscar("mascotas");
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Crear_mascota nuevo = new Crear_mascota(0);
            nuevo.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu atras = new menu();
            this.Hide();
            atras.Show();
        }

        private void opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(opciones.Text))
            {
                
                if (tipo == "Perro")
                {
                    vacuna1.Text = "Parvo";
                    vacuna2.Text = "Parvo/Corona";
                    vacuna3.Text = "Triple";
                    vacuna4.Text = "Quintuple";
                    vacuna5.Text = "Sextuple";
                    vacuna6.Text = "Rabia";
                    vacuna7.Visible = false;
                    raza.DataSource = null;
                    raza.DisplayMember = "NOMBRE";
                    raza.ValueMember = "NOMBRE";
                    raza.DataSource = Consultas.buscarColum("razas", "Perro", "ANIMAL");

                }
                else
                {
                    vacuna1.Text = "Leucemia ";
                    vacuna2.Text = "Triple veirica ";
                    vacuna3.Text = "Leucemia 2";
                    vacuna4.Text = "Triple virica 2";
                    vacuna5.Text = "PIF";
                    vacuna6.Text = "AntiRabica";
                    vacuna7.Visible = true;
                    vacuna7.Text = "PIF 2";
                    raza.DataSource = null;
                    raza.DisplayMember = "NOMBRE";
                    raza.ValueMember = "NOMBRE";
                    raza.DataSource = Consultas.buscarColum("razas", "Gato", "ANIMAL");
                }

                dt = Consultas.buscarFila("mascotas", "COMPLETO", opciones.Text);
                id.Text = dt.Rows[0][0].ToString();
                tipo = dt.Rows[0][1].ToString();
                if (tipo == "Perro") { cat.Checked = false; dog.Checked = true; }
                else { dog.Checked = false; cat.Checked = true; }
                nombre.Text = dt.Rows[0][2].ToString();
                string sex = dt.Rows[0][3].ToString();
                if (sex == "Macho") { women.Checked = false; men.Checked = true; }
                else { men.Checked = false; women.Checked = true; }
                edad.Text = dt.Rows[0][4].ToString();
                raza.Text = dt.Rows[0][5].ToString();
                razgos.Text = dt.Rows[0][6].ToString();
                dueño.Text = dt.Rows[0][8].ToString();
                fecha.Text = dt.Rows[0][9].ToString();
            }
        }

        private void dog_CheckedChanged(object sender, EventArgs e)
        {
            if (dog.Checked == true)
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Perro" ,"ANIMAL");
            }
            else
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Gato", "ANIMAL");
            }
        }

        private void Mascotas_Activated(object sender, EventArgs e)
        {
            opciones.DataSource = null;
            opciones.DisplayMember = "COMPLETO";
            opciones.ValueMember = "COMPLETO";
            opciones.DataSource = Consultas.buscar("mascotas");
        }

        private void acept_Click(object sender, EventArgs e)
        {
            string sex, tipo;
            int a;
            if (men.Checked == true) sex = "Macho";
            else sex = "Hembra";
            if (dog.Checked == true) tipo = "Perro";
            else tipo = "Gato";
            if (!string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(edad.Text) && !string.IsNullOrEmpty(razgos.Text) && !string.IsNullOrEmpty(tiempo.Text))
            {
                if (int.TryParse(edad.Text, out a))
                {

                    string completo = id.Text + " : " + nombre.Text + " | " + dueño.Text;
                    if (int.TryParse(nombre.Text, out a))
                    {
                        MessageBox.Show("No se permiten numeros el nombre");
                    }
                    else
                    {                       
                        string vida = (edad.Text + " " + tiempo.Text);
                        Consultas.actualizar_Mascota(id.Text, tipo, nombre.Text, sex, vida,razgos.Text, dueño.Text, completo, raza.Text);
                        Consultas.actualizar_Relacion(dueño.Text, id.Text);
                        
                    }
                }
                else MessageBox.Show("Solo numeros en la edad");
            }
            else MessageBox.Show("Llene todo los campos");
        }
    }
    }

