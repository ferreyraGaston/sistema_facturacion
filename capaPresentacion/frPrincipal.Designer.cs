namespace capaPresentacion
{
    partial class frPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            panel1 = new Panel();
            PicMin = new PictureBox();
            PicSalir = new PictureBox();
            PicMax = new PictureBox();
            PicRestaurar = new PictureBox();
            MenuVertical = new Panel();
            btn_Transporte = new Button();
            panel6 = new Panel();
            btn_Facturacion = new Button();
            panel4 = new Panel();
            btn_Presupuesto = new Button();
            panel5 = new Panel();
            btn_Clientes = new Button();
            panel3 = new Panel();
            btn_Productos = new Button();
            panel2 = new Panel();
            PanelSalir = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRestaurar).BeginInit();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(PicMin);
            panel1.Controls.Add(PicSalir);
            panel1.Controls.Add(PicMax);
            panel1.Controls.Add(PicRestaurar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 35);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // PicMin
            // 
            PicMin.Cursor = Cursors.Hand;
            PicMin.Image = (Image)resources.GetObject("PicMin.Image");
            PicMin.Location = new Point(1110, 3);
            PicMin.Name = "PicMin";
            PicMin.Size = new Size(27, 29);
            PicMin.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMin.TabIndex = 0;
            PicMin.TabStop = false;
            PicMin.Click += PicMin_Click;
            // 
            // PicSalir
            // 
            PicSalir.Cursor = Cursors.Hand;
            PicSalir.Image = (Image)resources.GetObject("PicSalir.Image");
            PicSalir.Location = new Point(1176, 6);
            PicSalir.Name = "PicSalir";
            PicSalir.Size = new Size(27, 29);
            PicSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            PicSalir.TabIndex = 3;
            PicSalir.TabStop = false;
            PicSalir.Click += PicSalir_Click;
            // 
            // PicMax
            // 
            PicMax.Cursor = Cursors.Hand;
            PicMax.Image = (Image)resources.GetObject("PicMax.Image");
            PicMax.Location = new Point(1143, 3);
            PicMax.Name = "PicMax";
            PicMax.Size = new Size(27, 29);
            PicMax.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMax.TabIndex = 2;
            PicMax.TabStop = false;
            PicMax.Click += PicMax_Click;
            // 
            // PicRestaurar
            // 
            PicRestaurar.Cursor = Cursors.Hand;
            PicRestaurar.Image = (Image)resources.GetObject("PicRestaurar.Image");
            PicRestaurar.Location = new Point(1143, 3);
            PicRestaurar.Name = "PicRestaurar";
            PicRestaurar.Size = new Size(27, 29);
            PicRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            PicRestaurar.TabIndex = 1;
            PicRestaurar.TabStop = false;
            PicRestaurar.Click += PicRestaurar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(128, 255, 255);
            MenuVertical.Controls.Add(btn_Transporte);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btn_Facturacion);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btn_Presupuesto);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(btn_Clientes);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btn_Productos);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.ForeColor = Color.White;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(221, 553);
            MenuVertical.TabIndex = 1;
            // 
            // btn_Transporte
            // 
            btn_Transporte.BackColor = Color.Green;
            btn_Transporte.Cursor = Cursors.Hand;
            btn_Transporte.FlatAppearance.BorderColor = Color.Green;
            btn_Transporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Transporte.FlatStyle = FlatStyle.Flat;
            btn_Transporte.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Transporte.Location = new Point(33, 349);
            btn_Transporte.Name = "btn_Transporte";
            btn_Transporte.Size = new Size(188, 32);
            btn_Transporte.TabIndex = 8;
            btn_Transporte.Text = "Transporte";
            btn_Transporte.UseVisualStyleBackColor = false;
            btn_Transporte.Click += btn_Transporte_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Green;
            panel6.Location = new Point(23, 349);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 32);
            panel6.TabIndex = 9;
            // 
            // btn_Facturacion
            // 
            btn_Facturacion.BackColor = Color.Green;
            btn_Facturacion.Cursor = Cursors.Hand;
            btn_Facturacion.FlatAppearance.BorderColor = Color.Green;
            btn_Facturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Facturacion.FlatStyle = FlatStyle.Flat;
            btn_Facturacion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Facturacion.Location = new Point(33, 301);
            btn_Facturacion.Name = "btn_Facturacion";
            btn_Facturacion.Size = new Size(188, 32);
            btn_Facturacion.TabIndex = 6;
            btn_Facturacion.Text = "Facturación";
            btn_Facturacion.UseVisualStyleBackColor = false;
            btn_Facturacion.Click += btn_Facturacion_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(23, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 32);
            panel4.TabIndex = 7;
            // 
            // btn_Presupuesto
            // 
            btn_Presupuesto.BackColor = Color.Green;
            btn_Presupuesto.Cursor = Cursors.Hand;
            btn_Presupuesto.FlatAppearance.BorderColor = Color.Green;
            btn_Presupuesto.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Presupuesto.FlatStyle = FlatStyle.Flat;
            btn_Presupuesto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Presupuesto.Location = new Point(33, 254);
            btn_Presupuesto.Name = "btn_Presupuesto";
            btn_Presupuesto.Size = new Size(188, 32);
            btn_Presupuesto.TabIndex = 4;
            btn_Presupuesto.Text = "Presupuesto";
            btn_Presupuesto.UseVisualStyleBackColor = false;
            btn_Presupuesto.Click += btn_Presupuesto_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Green;
            panel5.Location = new Point(23, 254);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 32);
            panel5.TabIndex = 5;
            // 
            // btn_Clientes
            // 
            btn_Clientes.BackColor = Color.Green;
            btn_Clientes.Cursor = Cursors.Hand;
            btn_Clientes.FlatAppearance.BorderColor = Color.Green;
            btn_Clientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Clientes.FlatStyle = FlatStyle.Flat;
            btn_Clientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clientes.Location = new Point(33, 206);
            btn_Clientes.Name = "btn_Clientes";
            btn_Clientes.Size = new Size(188, 32);
            btn_Clientes.TabIndex = 2;
            btn_Clientes.Text = "Clientes";
            btn_Clientes.UseVisualStyleBackColor = false;
            btn_Clientes.Click += btn_Clientes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Location = new Point(23, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 32);
            panel3.TabIndex = 3;
            // 
            // btn_Productos
            // 
            btn_Productos.BackColor = Color.Green;
            btn_Productos.Cursor = Cursors.Hand;
            btn_Productos.FlatAppearance.BorderColor = Color.Green;
            btn_Productos.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btn_Productos.FlatStyle = FlatStyle.Flat;
            btn_Productos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Productos.Location = new Point(33, 159);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Size = new Size(188, 32);
            btn_Productos.TabIndex = 0;
            btn_Productos.Text = "Productos";
            btn_Productos.UseVisualStyleBackColor = false;
            btn_Productos.Click += btn_Productos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(23, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 32);
            panel2.TabIndex = 1;
            // 
            // PanelSalir
            // 
            PanelSalir.BackColor = Color.FromArgb(192, 255, 192);
            PanelSalir.Dock = DockStyle.Fill;
            PanelSalir.Location = new Point(221, 35);
            PanelSalir.Name = "PanelSalir";
            PanelSalir.Size = new Size(994, 553);
            PanelSalir.TabIndex = 2;
            PanelSalir.Paint += PanelSalir_Paint;
            // 
            // frPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 588);
            Controls.Add(PanelSalir);
            Controls.Add(MenuVertical);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRestaurar).EndInit();
            MenuVertical.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel MenuVertical;
        private PictureBox PicSalir;
        private PictureBox PicMax;
        private PictureBox PicRestaurar;
        private PictureBox PicMin;
        private Panel PanelSalir;
        private Button btn_Productos;
        private Panel panel2;
        private Button btn_Clientes;
        private Panel panel3;
        private Button btn_Transporte;
        private Panel panel6;
        private Button btn_Facturacion;
        private Panel panel4;
        private Button btn_Presupuesto;
        private Panel panel5;
    }
}