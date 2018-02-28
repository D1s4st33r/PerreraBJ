namespace PerreraBJ
{
    partial class Dueños
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dueños));
            this.buscar = new System.Windows.Forms.TextBox();
            this.opciones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mascotas = new System.Windows.Forms.ListBox();
            this.adopcion = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nacimineto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.women = new System.Windows.Forms.RadioButton();
            this.men = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.amaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aparterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.MistyRose;
            this.buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(30, 119);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(153, 23);
            this.buscar.TabIndex = 0;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // opciones
            // 
            this.opciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opciones.FormattingEnabled = true;
            this.opciones.ItemHeight = 17;
            this.opciones.Location = new System.Drawing.Point(21, 171);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(208, 89);
            this.opciones.TabIndex = 1;
            this.opciones.SelectedIndexChanged += new System.EventHandler(this.opciones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ingrese un Nombre o ID";
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(206, 119);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(23, 23);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "+";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(89, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 25;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Mascotas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(669, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "En Adopcion";
            // 
            // mascotas
            // 
            this.mascotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascotas.FormattingEnabled = true;
            this.mascotas.ItemHeight = 17;
            this.mascotas.Location = new System.Drawing.Point(375, 385);
            this.mascotas.Name = "mascotas";
            this.mascotas.Size = new System.Drawing.Size(198, 123);
            this.mascotas.TabIndex = 30;
            // 
            // adopcion
            // 
            this.adopcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopcion.FormattingEnabled = true;
            this.adopcion.IntegralHeight = false;
            this.adopcion.ItemHeight = 17;
            this.adopcion.Location = new System.Drawing.Point(619, 385);
            this.adopcion.Name = "adopcion";
            this.adopcion.Size = new System.Drawing.Size(198, 123);
            this.adopcion.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buscar);
            this.groupBox1.Controls.Add(this.opciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 292);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSQUEDA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ciudad);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.telefono);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.direccion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nacimineto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.women);
            this.groupBox2.Controls.Add(this.men);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.amaterno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.aparterno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(341, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 299);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTUALIZACION";
            // 
            // ciudad
            // 
            this.ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(398, 114);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(121, 25);
            this.ciudad.TabIndex = 114;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(311, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 19);
            this.label14.TabIndex = 113;
            this.label14.Text = "Ciudad";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(389, 28);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 19);
            this.fecha.TabIndex = 112;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(86, 28);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 19);
            this.id.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 19);
            this.label11.TabIndex = 110;
            this.label11.Text = "Fecha de registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 19);
            this.label12.TabIndex = 109;
            this.label12.Text = "ID";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 108;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(299, 186);
            this.telefono.MaxLength = 10;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(177, 22);
            this.telefono.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 106;
            this.label8.Text = "Telefono";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(117, 220);
            this.direccion.MaxLength = 40;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(346, 22);
            this.direccion.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 104;
            this.label7.Text = "Direccion";
            // 
            // nacimineto
            // 
            this.nacimineto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimineto.Location = new System.Drawing.Point(398, 156);
            this.nacimineto.Name = "nacimineto";
            this.nacimineto.Size = new System.Drawing.Size(103, 23);
            this.nacimineto.TabIndex = 103;
            this.nacimineto.Value = new System.DateTime(2017, 7, 21, 1, 57, 52, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // women
            // 
            this.women.AutoSize = true;
            this.women.BackColor = System.Drawing.Color.Transparent;
            this.women.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.women.Location = new System.Drawing.Point(78, 182);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(89, 21);
            this.women.TabIndex = 101;
            this.women.TabStop = true;
            this.women.Text = "Femenino";
            this.women.UseVisualStyleBackColor = false;
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.BackColor = System.Drawing.Color.Transparent;
            this.men.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men.Location = new System.Drawing.Point(76, 155);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(90, 21);
            this.men.TabIndex = 100;
            this.men.TabStop = true;
            this.men.Text = "Masculino";
            this.men.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Sexo";
            // 
            // amaterno
            // 
            this.amaterno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amaterno.Location = new System.Drawing.Point(161, 114);
            this.amaterno.MaxLength = 30;
            this.amaterno.Name = "amaterno";
            this.amaterno.Size = new System.Drawing.Size(128, 22);
            this.amaterno.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 97;
            this.label4.Text = "Apellido Materno";
            // 
            // aparterno
            // 
            this.aparterno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aparterno.Location = new System.Drawing.Point(395, 77);
            this.aparterno.MaxLength = 30;
            this.aparterno.Name = "aparterno";
            this.aparterno.Size = new System.Drawing.Size(124, 22);
            this.aparterno.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 95;
            this.label2.Text = "Apellido Paterno";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(95, 77);
            this.nombre.MaxLength = 30;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(136, 22);
            this.nombre.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(548, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 95;
            this.label13.Text = "DUEÑOS";
            // 
            // Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 529);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adopcion);
            this.Controls.Add(this.mascotas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dueños";
            this.Activated += new System.EventHandler(this.Dueños_Activated);
            this.Load += new System.EventHandler(this.Dueños_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.ListBox opciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox mascotas;
        private System.Windows.Forms.ListBox adopcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker nacimineto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton women;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aparterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
    }
}