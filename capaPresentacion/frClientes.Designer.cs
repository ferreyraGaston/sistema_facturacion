namespace capaPresentacion
{
    partial class frClientes
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
            txtProvincia = new ComboBox();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            gridDatos = new DataGridView();
            txtTelefono = new NumericUpDown();
            txtId = new NumericUpDown();
            label5 = new Label();
            txtCuil = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtLocalidad = new ComboBox();
            label7 = new Label();
            textEmail = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            textRazonSocial = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDomicilio = new TextBox();
            txtDescuento = new NumericUpDown();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescuento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // txtProvincia
            // 
            txtProvincia.FormattingEnabled = true;
            txtProvincia.Location = new Point(141, 115);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(223, 23);
            txtProvincia.TabIndex = 22;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(396, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(482, 23);
            txtBuscar.TabIndex = 26;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(895, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gridDatos
            // 
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(396, 115);
            gridDatos.Name = "gridDatos";
            gridDatos.RowTemplate.Height = 25;
            gridDatos.Size = new Size(574, 418);
            gridDatos.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.DecimalPlaces = 2;
            txtTelefono.Location = new Point(141, 225);
            txtTelefono.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(222, 23);
            txtTelefono.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(141, 82);
            txtId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 200);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 31;
            label5.Text = "Cuil";
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(140, 192);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(223, 23);
            txtCuil.TabIndex = 23;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(288, 510);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(197, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(94, 510);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 123);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 21;
            label3.Text = "Provincia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 233);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 19;
            label2.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 90);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 18;
            label6.Text = "Código";
            // 
            // txtLocalidad
            // 
            txtLocalidad.FormattingEnabled = true;
            txtLocalidad.Location = new Point(140, 155);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(223, 23);
            txtLocalidad.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 163);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 35;
            label7.Text = "Localidad";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(140, 350);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(223, 23);
            textEmail.TabIndex = 37;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 265);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 273);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 38;
            label4.Text = "Nombre";
            // 
            // textRazonSocial
            // 
            textRazonSocial.Location = new Point(140, 307);
            textRazonSocial.Name = "textRazonSocial";
            textRazonSocial.Size = new Size(223, 23);
            textRazonSocial.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 315);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 40;
            label8.Text = "Razon Social";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 358);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 42;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 409);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 44;
            label10.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(140, 401);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(223, 23);
            txtDomicilio.TabIndex = 43;
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(140, 442);
            txtDescuento.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(120, 23);
            txtDescuento.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 450);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 45;
            label11.Text = "Descuento";
            // 
            // frClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 545);
            Controls.Add(txtDescuento);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtDomicilio);
            Controls.Add(label9);
            Controls.Add(textRazonSocial);
            Controls.Add(label8);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(textEmail);
            Controls.Add(txtLocalidad);
            Controls.Add(label7);
            Controls.Add(txtProvincia);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(gridDatos);
            Controls.Add(txtTelefono);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(txtCuil);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frClientes";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescuento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox txtProvincia;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView gridDatos;
        private NumericUpDown txtTelefono;
        private NumericUpDown txtId;
        private Label label5;
        private TextBox txtCuil;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Label label3;
        private Label label2;
        private Label label6;
        private ComboBox txtLocalidad;
        private Label label7;
        private TextBox textEmail;
        private TextBox txtNombre;
        private Label label4;
        private TextBox textRazonSocial;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDomicilio;
        private NumericUpDown txtDescuento;
        private Label label11;
    }
}