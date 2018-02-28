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
    public partial class Crear_cartilla : Form
    {
        string tipo, id;
        string vacuna1 = null, vacuna2 = null, vacuna3 = null, vacuna4 = null, vacuna5 = null, vacuna6 = null, vacuna7 = null;

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
            vacuna2 = fecha2.Value.ToString("dd/MM/yyyy");
            if (vacuna2 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna2 = null;
        }

        private void fecha3_ValueChanged(object sender, EventArgs e)
        {
            vacuna3 = fecha3.Value.ToString("dd/MM/yyyy");
            if (vacuna3 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna3 = null;
        }

        private void fecha4_ValueChanged(object sender, EventArgs e)
        {
            vacuna4 = fecha4.Value.ToString("dd/MM/yyyy");
            if (vacuna4 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna4 = null;
        }

        private void fecha5_ValueChanged(object sender, EventArgs e)
        {
            vacuna5 = fecha5.Value.ToString("dd/MM/yyyy");
            if (vacuna5 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna5 = null;
        }

        private void fecha6_ValueChanged(object sender, EventArgs e)
        {
            vacuna6 = fecha6.Value.ToString("dd/MM/yyyy");
            if (vacuna6 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna6 = null;
        }

        private void fecha7_ValueChanged(object sender, EventArgs e)
        {
            vacuna7 = fecha7.Value.ToString("dd/MM/yyyy");
            if (vacuna7 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna7 = null;
        }

        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
            vacuna1 = fecha1.Value.ToString("dd/MM/yyyy");
            if (vacuna1 == DateTime.Now.ToString("dd/MM/yyyy")) vacuna1 = null;
        }

        DataTable dt = new DataTable();
        public Crear_cartilla()
        {
            InitializeComponent();

        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            mascota.DataSource = null;
            if(!string.IsNullOrEmpty(buscar.Text))
            {
                mascota.DisplayMember = "COMPLETO";
                mascota.ValueMember = "COMPLETO";
                mascota.DataSource = Consultas.buscarxRef("mascotas", "COMPLETO", buscar.Text);
            }
            else
            {
                mascota.DisplayMember = "COMPLETO";
                mascota.ValueMember = "COMPLETO";
                mascota.DataSource = Consultas.buscar("mascotas");
            }
        }

        private void mascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(mascota.Text))
            {
                dt = Consultas.buscarFila("mascotas", "COMPLETO", mascota.Text);
                tipo = dt.Rows[0][1].ToString();
                id = dt.Rows[0][0].ToString();
                if(tipo=="Perro")
                {
                    v1.Text = "Parvo";
                    v2.Text = "Parvo/Corona";
                    v3.Text = "Triple";
                    v4.Text = "Quintuple";
                    v5.Text = "Sextuple";
                    v6.Text = "Rabia";
                    v7.Visible = false;
                    fecha7.Visible = false;
                  
                }
                else
                {
                    v1.Text = "Leucemia";
                    v2.Text = "Triple virica";
                    v3.Text = "Leucemia 2";
                    v4.Text = "Triple virica 2";
                    v5.Text = "PIF";
                    v6.Text = "Rabia";
                    v7.Visible = false;
                    v7.Text = "PIF 2";
                    fecha7.Visible = false;
                }
            }
        }

        private void Crear_cartilla_Load(object sender, EventArgs e)
        {

        }

        private void acept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mascota.Text))
            {
                Consultas.actualizar_vacuna(tipo, id, vacuna1, vacuna2, vacuna3, vacuna4, vacuna5, vacuna6, vacuna7);
                this.Hide();           
            }
            else MessageBox.Show("Seleccione una mascota");
        }
    }
}
