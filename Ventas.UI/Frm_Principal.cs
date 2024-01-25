using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.UI.Informes;

namespace Ventas.UI
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        private Frm_Categoria frmCategoria; // Declarar una variable para el formulario de Categoría
        private Frm_Producto frmProducto;   // Declarar una variable para el formulario de Producto

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        
      
        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            //Frm_Categoria frm1 = new Frm_Categoria();
            //frm1.MdiParent = this;
            //frm1.Show();
            if (frmProducto != null && !frmProducto.IsDisposed)
            {
                frmProducto.Close();
                frmProducto = null;
            }

            // Abrir el formulario de Categoría si no está abierto
            if (frmCategoria == null || frmCategoria.IsDisposed)
            {
                frmCategoria = new Frm_Categoria();
                frmCategoria.MdiParent = this;
                frmCategoria.Show();

            }
        }


        private void btn_Productos_Click(object sender, EventArgs e)
        {
            //Frm_Producto frm1 = new Frm_Producto();
            //frm1.MdiParent = this;
            //frm1.Show();
            if (frmCategoria != null && !frmCategoria.IsDisposed)
            {
                frmCategoria.Close();
                frmCategoria = null;
            }

            // Abrir el formulario de Producto si no está abierto
            if (frmProducto == null || frmProducto.IsDisposed)
            {
                frmProducto = new Frm_Producto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
        }
    

       

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Productos r1 = new Frm_Rpt_Productos();
            r1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_miperfil_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
