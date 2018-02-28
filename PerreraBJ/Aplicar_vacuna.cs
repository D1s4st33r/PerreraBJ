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
    public partial class Aplicar_vacuna : Form
    {
        string edad,referencia,tipo,id;
        DataTable dt = new DataTable();
        public Aplicar_vacuna()
        {
            InitializeComponent();
        }

        private void Aplicar_vacuna_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                mascota.DataSource = null;
                mascota.DisplayMember = "COMPLETO";
                mascota.ValueMember = "COMPLETO";
                mascota.DataSource = Consultas.buscarxRef("mascotas", "COMPLETO", textBox1.Text);
            }
            else
            {
                mascota.DataSource = null;
                mascota.DisplayMember = "COMPLETO";
                mascota.ValueMember = "COMPLETO";
                mascota.DataSource = Consultas.buscar("mascotas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mascota_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty( mascota.Text))
            {
                vacuna.DataSource = null;
                dt = Consultas.buscarFila("mascotas", "COMPLETO", mascota.Text);
                id = dt.Rows[0][0].ToString();
                tipo = dt.Rows[0][1].ToString();
                edad = dt.Rows[0][4].ToString();
                if (tipo == "Perro")
                {
                    vacuna.DisplayMember = "NOMBRE";
                    vacuna.ValueMember = "NOMBRE";
                    vacuna.DataSource = Consultas.buscarColum("vacunas", tipo.ToUpper(), "MASCOTA");
                }
                else
                {
                    vacuna.DisplayMember = "NOMBRE";
                    vacuna.ValueMember = "NOMBRE";
                    vacuna.DataSource = Consultas.buscarColum("vacunas", tipo, "MASCOTA");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mascota.Text) && !string.IsNullOrEmpty(vacuna.Text))
            {
                if (edad == referencia)
                {
                    if (tipo == "Perro")
                    { Consultas.actualizar_dato("detalle_vacuna_perros", vacuna.Text.ToUpper(), fecha.Text, id, "IDPERRO"); this.Hide(); }
                    else { Consultas.actualizar_dato("detalle_vacuna_gatos", vacuna.Text.ToUpper(), fecha.Text, id, "IDGATO"); this.Hide(); }
                }
                else MessageBox.Show("La edad de la mascota\nno es adecuada para la vacuna");
            }
            else MessageBox.Show("Seleccione algun dato\n en los campos existentes");
        }

        private void vacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(vacuna.Text))
            {
                dt = Consultas.buscarFila("vacunas", "NOMBRE", vacuna.Text);
                referencia = dt.Rows[0][3].ToString();
            }
        }
    }
}
