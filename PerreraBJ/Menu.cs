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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void duenio_Click(object sender, EventArgs e)
        {
            Dueños nuevo = new Dueños();
            this.Hide();
            nuevo.Show();
        }

        private void mascota_Click(object sender, EventArgs e)
        {
            Mascotas nuevo = new Mascotas();
            this.Hide();
            nuevo.Show();
        }

        private void vacuna_Click(object sender, EventArgs e)
        {
            Vacuna nuevo = new Vacuna();
            this.Hide();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RyA nuevo = new RyA();
            this.Hide();
            nuevo.Show();
        }
    }
}
