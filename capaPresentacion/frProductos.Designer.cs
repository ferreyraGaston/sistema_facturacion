namespace capaPresentacion
{
    partial class frProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lnkFoto = new LinkLabel();
            picFoto = new PictureBox();
            ofdFoto = new OpenFileDialog();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtCodigo = new NumericUpDown();
            txtPrecio = new NumericUpDown();
            gridDatos = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label6 = new Label();
            txtCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 192);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 106);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 225);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Imagen";
            // 
            // lnkFoto
            // 
            lnkFoto.AutoSize = true;
            lnkFoto.Location = new Point(128, 225);
            lnkFoto.Name = "lnkFoto";
            lnkFoto.Size = new Size(110, 15);
            lnkFoto.TabIndex = 4;
            lnkFoto.TabStop = true;
            lnkFoto.Text = "Seleccionar Imagen";
            lnkFoto.LinkClicked += lnkFoto_LinkClicked;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ButtonShadow;
            picFoto.Location = new Point(128, 268);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(235, 193);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 5;
            picFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(27, 320);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(27, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(127, 184);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 146);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "Categoría";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(128, 69);
            txtCodigo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 14;
            // 
            // txtPrecio
            // 
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Location = new Point(127, 104);
            txtPrecio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 23);
            txtPrecio.TabIndex = 1;
            // 
            // gridDatos
            // 
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(383, 82);
            gridDatos.Name = "gridDatos";
            gridDatos.RowTemplate.Height = 25;
            gridDatos.Size = new Size(574, 379);
            gridDatos.TabIndex = 16;
            gridDatos.CellContentDoubleClick += gridDatos_CellContentDoubleClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(882, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(383, 43);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(482, 23);
            txtBuscar.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 10);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 19;
            label6.Text = "Productos";
            // 
            // txtCategoria
            // 
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Location = new Point(128, 143);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(235, 23);
            txtCategoria.TabIndex = 2;
            // 
            // frProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 482);
            Controls.Add(txtCategoria);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(gridDatos);
            Controls.Add(txtPrecio);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(lnkFoto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frProductos";
            Text = "Productos";
            Load += frClientes_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel lnkFoto;
        private PictureBox picFoto;
        private OpenFileDialog ofdFoto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Label label5;
        private NumericUpDown txtCodigo;
        private NumericUpDown txtPrecio;
        private DataGridView gridDatos;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label6;
        private ComboBox txtCategoria;
    }
}