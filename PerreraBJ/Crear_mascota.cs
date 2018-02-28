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
    public partial class Crear_mascota : Form
    {
        DataTable dt = new DataTable();
        int cen;
        string idd;
        public Crear_mascota(int x)
        {
            InitializeComponent();
            cen = x;
        }

        private void Crear_mascota_Load(object sender, EventArgs e)
        {
            if (cen == 1) agregar.Visible = false; else agregar.Visible = true;

            dueño.DisplayMember="COMPLETO";
            dueño.ValueMember = "COMPLETO";
            dueño.DataSource = Consultas.buscar("duenio");
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            id.Text =Consultas.contar("mascotas", "ID").ToString();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void acept_Click(object sender, EventArgs e)
        {
            string sex,tipo;
            int a;
            if (men.Checked == true) sex = "Macho";
            else sex = "Hembra";
            if(dog.Checked == true) tipo = "Perro";
            else tipo = "Gato";
            if (!string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(edad.Text) && !string.IsNullOrEmpty(razgos.Text)&&!string.IsNullOrEmpty(tiempo.Text))
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
                        dt = Consultas.buscarFila("duenio", "COMPLETO", dueño.Text);
                        idd = dt.Rows[0][0].ToString();
                        string vida = (edad.Text + " " + tiempo.Text);
                        Consultas.crearMascota(id.Text,tipo, nombre.Text, sex,vida, fecha.Text, razgos.Text,dueño.Text, completo,raza.Text,"Mascota");
                        Consultas.crearRelacion(idd, id.Text);
                        if (tipo == "Perro") Consultas.crearVacuna(id.Text, "detalle_vacuna_perros", "IDPERRO",nombre.Text);
                        else Consultas.crearVacuna(id.Text, "detalle_vacuna_gatos", "IDGATO",nombre.Text);

                        this.Hide();
                    }
                }
                else MessageBox.Show("Solo numeros en la edad");
            }
            else MessageBox.Show("Llene todo los campos");
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Crear_dueño nuevo = new Crear_dueño();
            nuevo.Show();
        }

        private void dog_CheckedChanged(object sender, EventArgs e)
        {
            if (dog.Checked == true)
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Perro","ANIMAL");
            }
            else
            {
                raza.DataSource = null;
                raza.DisplayMember = "NOMBRE";
                raza.ValueMember = "NOMBRE";
                raza.DataSource = Consultas.buscarColum("razas", "Gato", "ANIMAL");
            }
        }
    }
    }

