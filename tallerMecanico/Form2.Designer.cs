namespace tallerMecanico
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            btnEliminar = new Button();
            label7 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gridClientes = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(69, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos del Cliente ";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 31, 39);
            label8.Location = new Point(328, 168);
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
            btnEliminar.Location = new Point(286, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 36);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = " ";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 31, 39);
            label7.Location = new Point(176, 168);
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
            label5.Location = new Point(479, 168);
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
            btnAgregar.Location = new Point(439, 161);
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
            btnModificar.Location = new Point(134, 161);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(144, 36);
            btnModificar.TabIndex = 10;
            btnModificar.Text = " ";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Montserrat", 12F);
            txtDireccion.ForeColor = Color.FromArgb(255, 98, 31);
            txtDireccion.Location = new Point(134, 116);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(449, 27);
            txtDireccion.TabIndex = 7;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Montserrat", 12F);
            txtCorreo.ForeColor = Color.FromArgb(255, 98, 31);
            txtCorreo.Location = new Point(379, 72);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(204, 27);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Montserrat", 12F);
            txtTelefono.ForeColor = Color.FromArgb(255, 98, 31);
            txtTelefono.Location = new Point(134, 72);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(147, 27);
            txtTelefono.TabIndex = 5;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Montserrat", 12F);
            txtNombre.ForeColor = Color.FromArgb(255, 98, 31);
            txtNombre.Location = new Point(134, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(449, 27);
            txtNombre.TabIndex = 4;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 31, 39);
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 3;
            label4.Text = "DIRECCIÓN:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 31, 39);
            label3.Location = new Point(287, 75);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 2;
            label3.Text = "CORREO:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 31, 39);
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 1;
            label2.Text = "TELÉFONO:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 31, 39);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 400);
            gridClientes.Name = "gridClientes";
            gridClientes.Size = new Size(717, 165);
            gridClientes.TabIndex = 2;
            gridClientes.CellClick += gridClientes_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(279, 365);
            label6.Name = "label6";
            label6.Size = new Size(181, 22);
            label6.TabIndex = 3;
            label6.Text = "- Listado de Clientes -";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 153, 179);
            ClientSize = new Size(741, 601);
            Controls.Add(label6);
            Controls.Add(gridClientes);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClientes";
            Text = "Sistema de Gestión - CLIENTES";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDireccion;
        private Label label5;
        private Button btnAgregar;
        private Label label8;
        private Button btnEliminar;
        private Label label7;
        private Button btnModificar;
        private DataGridView gridClientes;
        private Label label6;
    }
}