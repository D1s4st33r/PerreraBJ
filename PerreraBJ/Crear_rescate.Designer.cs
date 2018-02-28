namespace PerreraBJ
{
    partial class Crear_rescate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_rescate));
            this.label11 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.men = new System.Windows.Forms.RadioButton();
            this.women = new System.Windows.Forms.RadioButton();
            this.cat = new System.Windows.Forms.RadioButton();
            this.dog = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.razgos = new System.Windows.Forms.RichTextBox();
            this.raza = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acept = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.condicion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lugar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, -31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 19);
            this.label11.TabIndex = 132;
            this.label11.Text = "Registro de Mascotas";
            // 
            // tiempo
            // 
            this.tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.FormattingEnabled = true;
            this.tiempo.Items.AddRange(new object[] {
            "Semanas",
            "Meses",
            "Años"});
            this.tiempo.Location = new System.Drawing.Point(620, 253);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(87, 24);
            this.tiempo.TabIndex = 131;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.men);
            this.groupBox1.Controls.Add(this.women);
            this.groupBox1.Location = new System.Drawing.Point(340, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 72);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // men
            // 
            this.men.AutoSize = true;
            this.men.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men.Location = new System.Drawing.Point(14, 20);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(71, 21);
            this.men.TabIndex = 83;
            this.men.TabStop = true;
            this.men.Text = "Macho";
            this.men.UseVisualStyleBackColor = true;
            // 
            // women
            // 
            this.women.AutoSize = true;
            this.women.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.women.Location = new System.Drawing.Point(14, 47);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(78, 21);
            this.women.TabIndex = 84;
            this.women.TabStop = true;
            this.women.Text = "Hembra";
            this.women.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.BackColor = System.Drawing.Color.Transparent;
            this.cat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(608, 182);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(65, 24);
            this.cat.TabIndex = 129;
            this.cat.TabStop = true;
            this.cat.Text = "Gato";
            this.cat.UseVisualStyleBackColor = false;
            // 
            // dog
            // 
            this.dog.AutoSize = true;
            this.dog.BackColor = System.Drawing.Color.Transparent;
            this.dog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dog.Location = new System.Drawing.Point(676, 182);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(66, 24);
            this.dog.TabIndex = 128;
            this.dog.TabStop = true;
            this.dog.Text = "Perro";
            this.dog.UseVisualStyleBackColor = false;
            this.dog.CheckedChanged += new System.EventHandler(this.dog_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(531, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 127;
            this.label10.Text = "Animal";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(12, 467);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 23);
            this.cancel.TabIndex = 125;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // razgos
            // 
            this.razgos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razgos.Location = new System.Drawing.Point(279, 340);
            this.razgos.Name = "razgos";
            this.razgos.Size = new System.Drawing.Size(212, 56);
            this.razgos.TabIndex = 122;
            this.razgos.Text = "";
            // 
            // raza
            // 
            this.raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raza.FormattingEnabled = true;
            this.raza.Location = new System.Drawing.Point(341, 184);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(136, 24);
            this.raza.TabIndex = 120;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(639, 69);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 19);
            this.fecha.TabIndex = 119;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(362, 69);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 19);
            this.id.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 19);
            this.label9.TabIndex = 117;
            this.label9.Text = "Fecha de registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 116;
            this.label3.Text = "ID";
            // 
            // acept
            // 
            this.acept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acept.Location = new System.Drawing.Point(594, 443);
            this.acept.Name = "acept";
            this.acept.Size = new System.Drawing.Size(87, 34);
            this.acept.TabIndex = 115;
            this.acept.Text = "Guardar";
            this.acept.UseVisualStyleBackColor = true;
            this.acept.Click += new System.EventHandler(this.acept_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 19);
            this.label7.TabIndex = 113;
            this.label7.Text = "Razgos particulares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 112;
            this.label6.Text = "Edad aproximada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 111;
            this.label5.Text = "Sexo";
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(523, 254);
            this.edad.MaxLength = 30;
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(83, 23);
            this.edad.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 109;
            this.label2.Text = "Raza";
            // 
            // condicion
            // 
            this.condicion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicion.Location = new System.Drawing.Point(530, 340);
            this.condicion.Name = "condicion";
            this.condicion.Size = new System.Drawing.Size(212, 56);
            this.condicion.TabIndex = 134;
            this.condicion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 133;
            this.label1.Text = "Condiciones de hallazgo";
            // 
            // lugar
            // 
            this.lugar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar.Location = new System.Drawing.Point(279, 431);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(212, 58);
            this.lugar.TabIndex = 136;
            this.lugar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 135;
            this.label4.Text = "Lugar de hallazgo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 28);
            this.label8.TabIndex = 137;
            this.label8.Text = "Registro de Rescate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 19);
            this.label12.TabIndex = 139;
            this.label12.Text = "Nombre temporal";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(447, 138);
            this.nombre.MaxLength = 30;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(159, 23);
            this.nombre.TabIndex = 138;
            // 
            // Crear_rescate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 520);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lugar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.condicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.razgos);
            this.Controls.Add(this.raza);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Crear_rescate";
            this.Text = "Rescate";
            this.Load += new System.EventHandler(this.Crear_rescate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton men;
        private System.Windows.Forms.RadioButton women;
        private System.Windows.Forms.RadioButton cat;
        private System.Windows.Forms.RadioButton dog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox razgos;
        private System.Windows.Forms.ComboBox raza;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox condicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nombre;
    }
}