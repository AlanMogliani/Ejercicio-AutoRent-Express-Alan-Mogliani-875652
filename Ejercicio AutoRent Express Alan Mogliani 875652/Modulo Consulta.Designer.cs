namespace Ejercicio_AutoRent_Express_Alan_Mogliani_875652
{
    partial class ModuloConsulta : Form
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
            label1 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            COD_RES = new DataGridViewTextBoxColumn();
            Dominio = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Verificador = new DataGridViewTextBoxColumn();
            EstadoVehiculo = new DataGridViewTextBoxColumn();
            FechaDevolucion = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "MODULO DE CONSULTA";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(124, 61);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(194, 23);
            textBox7.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 66);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 52;
            label7.Text = "Codigo de Reserva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 54;
            label2.Text = "PARAMETROS DE BUSQUEDA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 55;
            label3.Text = "Dominio:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 57;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 59;
            label5.Text = "Modelo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 61;
            label6.Text = "Ultimo Verificador:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(124, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 63;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(124, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 23);
            comboBox2.TabIndex = 64;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(124, 179);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 23);
            comboBox3.TabIndex = 65;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { COD_RES, Dominio, Marca, Modelo, Verificador, EstadoVehiculo, FechaDevolucion });
            dataGridView1.Location = new Point(10, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 159);
            dataGridView1.TabIndex = 67;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // COD_RES
            // 
            COD_RES.HeaderText = "Codigo Reserva";
            COD_RES.Name = "COD_RES";
            // 
            // Dominio
            // 
            Dominio.HeaderText = "Dominio";
            Dominio.Name = "Dominio";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            // 
            // Verificador
            // 
            Verificador.HeaderText = "Verificador";
            Verificador.Name = "Verificador";
            // 
            // EstadoVehiculo
            // 
            EstadoVehiculo.HeaderText = "Estado Vehiculo";
            EstadoVehiculo.Name = "EstadoVehiculo";
            // 
            // FechaDevolucion
            // 
            FechaDevolucion.HeaderText = "Fecha Devolucion";
            FechaDevolucion.Name = "FechaDevolucion";
            // 
            // button2
            // 
            button2.Location = new Point(676, 214);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 102;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(573, 214);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 101;
            button1.Text = "EJECUTAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(676, 418);
            button3.Name = "button3";
            button3.Size = new Size(97, 23);
            button3.TabIndex = 103;
            button3.Text = "DESCARGAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox7;
        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn COD_RES;
        private DataGridViewTextBoxColumn Dominio;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Verificador;
        private DataGridViewTextBoxColumn EstadoVehiculo;
        private DataGridViewTextBoxColumn FechaDevolucion;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}