using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PicMax.Visible = true;
            PicRestaurar.Visible = false;
        }

        private void PicMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PicMax.Visible = false;
            PicRestaurar.Visible = true;
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelSalir.Controls.Count > 0)  // pregunta si hay algun control en el interior del panel
                this.PanelSalir.Controls.RemoveAt(0); // si hay algun control lo elimina o remueve
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;  // hace que se acople el formulario al contenedor
            this.PanelSalir.Controls.Add(fh);  // agregamos el formulario al panel
            this.PanelSalir.Tag = fh;  // establecemo la instancia como contenedor de dato al panel
            fh.Show();  // mostramos el formulario.

        }
        private void PanelSalir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frProductos());
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frClientes());
        }

        private void btn_Presupuesto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frPresupuesto());
        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frFacturacion());
        }

        private void btn_Transporte_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frTransporte());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
