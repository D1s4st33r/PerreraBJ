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
    public partial class Vacuna : Form
    {
        
        public Vacuna()
        {
            InitializeComponent();
        }

        private void dog_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
           if(dog.Checked==true)
            {
                listBox1.DisplayMember = "NOMBRE";
                listBox1.ValueMember = "NOMBRE";
                listBox1.DataSource = Consultas.buscarColum("vacunas", "PERRO", "MASCOTA");
                dataGridView1.DataSource = Consultas.buscar("detalle_vacuna_perros");
            }
           else
            {
                listBox1.DisplayMember = "NOMBRE";
                listBox1.ValueMember = "NOMBRE";
                listBox1.DataSource = Consultas.buscarColum("vacunas", "Gato", "MASCOTA");
                dataGridView1.DataSource = Consultas.buscar("detalle_vacuna_gatos");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vacuna_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu nuevo = new menu();
            this.Hide();
            nuevo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aplicar_vacuna nuevo = new Aplicar_vacuna();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crear_cartilla nuevo = new Crear_cartilla();
            nuevo.Show();
        }

        private void Vacuna_Activated(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            if (dog.Checked == true) dataGridView1.DataSource = Consultas.buscar("detalle_vacuna_perros");
            else dataGridView1.DataSource = Consultas.buscar("detalle_vacuna_gatos");
            
        }
    }
    }

