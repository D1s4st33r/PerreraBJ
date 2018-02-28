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
    public partial class RyA : Form
    {
        public RyA()
        {
            InitializeComponent();
        }

        private void rescate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rescate.Text))
            {
                dataGridView1.DataSource = Consultas.buscarxRef("rescate", "ID", rescate.Text);
            }
            else dataGridView1.DataSource = Consultas.buscar("rescate");
        }

        private void RyA_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Consultas.buscar("rescate");
            dataGridView2.DataSource = Consultas.buscar("adopcion");
        }

        private void adopcion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(adopcion.Text))
            {
                dataGridView1.DataSource = Consultas.buscarxRef("adopcion", "COMPLETO", adopcion.Text);
            }
            else dataGridView1.DataSource = Consultas.buscar("adopcion");
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu nuevo = new menu();
            this.Hide();
            nuevo.Show();
        }

        private void rr_Click(object sender, EventArgs e)
        {
            Crear_rescate nuevo = new Crear_rescate();
            nuevo.Show();
        }

        private void ra_Click(object sender, EventArgs e)
        {
            Crear_adopcion nuevo = new Crear_adopcion();
            nuevo.Show();
        }
    }
}
