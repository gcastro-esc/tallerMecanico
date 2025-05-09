namespace tallerMecanico
{
    partial class frmVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtYear = new TextBox();
            txtPlacas = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtModelo = new TextBox();
            comboCliente = new ComboBox();
            label8 = new Label();
            btnEliminar = new Button();
            label7 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtMarca = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label9 = new Label();
            gridVehiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVehiculos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtPlacas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(comboCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(72, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 241);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos del Vehiculo";
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 31, 39);
            label3.Location = new Point(323, 131);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 19;
            label3.Text = "AÑO:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Montserrat", 12F);
            txtYear.ForeColor = Color.FromArgb(255, 98, 31);
            txtYear.Location = new Point(413, 128);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(170, 27);
            txtYear.TabIndex = 18;
            txtYear.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPlacas
            // 
            txtPlacas.Font = new Font("Montserrat", 12F);
            txtPlacas.ForeColor = Color.FromArgb(255, 98, 31);
            txtPlacas.Location = new Point(134, 128);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(170, 27);
            txtPlacas.TabIndex = 17;
            txtPlacas.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 31, 39);
            label6.Location = new Point(10, 130);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 16;
            label6.Text = "PLACAS:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 31, 39);
            label2.Location = new Point(323, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 15;
            label2.Text = "MODELO:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Montserrat", 12F);
            txtModelo.ForeColor = Color.FromArgb(255, 98, 31);
            txtModelo.Location = new Point(413, 83);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(170, 27);
            txtModelo.TabIndex = 14;
            txtModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // comboCliente
            // 
            comboCliente.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCliente.ForeColor = Color.FromArgb(255, 98, 31);
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(134, 28);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(449, 30);
            comboCliente.TabIndex = 13;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 31, 39);
            label8.Location = new Point(328, 195);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 11;
            label8.Text = "ELIMINAR";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.Font = new Font("Font Awesome 6 Free Solid", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(22, 31, 39);
            btnEliminar.Location = new Point(286, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 36);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = " ";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 31, 39);
            label7.Location = new Point(176, 195);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 9;
            label7.Text = "MODIFICAR";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 31, 39);
            label5.Location = new Point(479, 195);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 2;
            label5.Text = "AGREGAR";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(224, 224, 224);
            btnAgregar.Font = new Font("Font Awesome 6 Free Solid", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(22, 31, 39);
            btnAgregar.Location = new Point(439, 188);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 36);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = " ";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(224, 224, 224);
            btnModificar.Font = new Font("Font Awesome 6 Free Solid", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.FromArgb(22, 31, 39);
            btnModificar.Location = new Point(134, 188);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(144, 36);
            btnModificar.TabIndex = 10;
            btnModificar.Text = " ";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Montserrat", 12F);
            txtMarca.ForeColor = Color.FromArgb(255, 98, 31);
            txtMarca.Location = new Point(134, 83);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(170, 27);
            txtMarca.TabIndex = 7;
            txtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 31, 39);
            label4.Location = new Point(10, 85);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 3;
            label4.Text = "MARCA:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 31, 39);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 0;
            label1.Text = "CLIENTE:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(274, 420);
            label9.Name = "label9";
            label9.Size = new Size(193, 22);
            label9.TabIndex = 5;
            label9.Text = "- Listado de Vehículos -";
            // 
            // gridVehiculos
            // 
            gridVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVehiculos.Location = new Point(12, 451);
            gridVehiculos.Name = "gridVehiculos";
            gridVehiculos.Size = new Size(717, 165);
            gridVehiculos.TabIndex = 4;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 153, 179);
            ClientSize = new Size(741, 644);
            Controls.Add(label9);
            Controls.Add(gridVehiculos);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculos";
            Text = "Sistema de Gestión - VEHICULOS";
            Load += frmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ComboBox comboCliente;
        private Label label8;
        private Button btnEliminar;
        private Label label7;
        private Label label5;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtMarca;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox txtYear;
        private TextBox txtPlacas;
        private Label label6;
        private Label label2;
        private TextBox txtModelo;
        private Label label9;
        private DataGridView gridVehiculos;
    }
}