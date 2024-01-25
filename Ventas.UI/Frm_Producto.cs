using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BLL;
using Ventas.Entities;

namespace Ventas.UI
{
    public partial class Frm_Producto : Form
    {
        public Frm_Producto()
        {
            InitializeComponent();

        }
        ProductoBLL bll = new ProductoBLL();
        Articulo objPro = new Articulo();
        CategoriaBLL objCat = new CategoriaBLL();
        
        void Limpiar()
        {
            txtNombre.Text = "";
            Estado.Checked = false;
            comboCat.SelectedIndex = 0;
            txtDescrip.Text = "";
            txtPrecio.Text = "";
        }

        void ListarCategoria()
        {
            comboCat.DataSource = objCat.ListarCategoria();
            comboCat.DisplayMember = "Nombre";
            comboCat.ValueMember = "IdCategoria";
        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Nuevo.Enabled = false;
            Limpia();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
        void Limpia()
        {
            txtNombre.Text = "";
            Estado.Checked = false;
            txtDescrip.Text = "";
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            {
                Panel_Agregar.Visible = true;
                btn_Guardar.Text = "Actualizar";
                txtIdPro.Text = DataProducto.CurrentRow.Cells[0].Value.ToString();

                // Obtén el valor de la categoría del producto seleccionado
                int categoriaId = Convert.ToInt32(DataProducto.CurrentRow.Cells[1].Value.ToString()) - 1;

                // Busca el índice correspondiente en el ComboBox y configúralo como seleccionado
                if (categoriaId >= 0 && categoriaId < comboCat.Items.Count)
                {
                    comboCat.SelectedIndex = categoriaId;
                }

                txtNombre.Text = DataProducto.CurrentRow.Cells[2].Value.ToString();
                txtDescrip.Text = DataProducto.CurrentRow.Cells[3].Value.ToString();
                txtPrecio.Text = DataProducto.CurrentRow.Cells[4].Value.ToString();

                if (DataProducto.CurrentRow.Cells[5].Value is true)
                {
                    this.Estado.Checked = true;
                }
                else
                {
                    this.Estado.Checked = false;
                }

                this.btn_Actualizar.Enabled = false;
                this.btn_Nuevo.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                DataProducto.DataSource = bll.ListarProductos();
            }
            else
            {
                DataProducto.DataSource = bll.ListarxNombre(txtBuscar.Text);
            }
        }

       

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Panel_Agregar.Visible = false;
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Guardar")
            {       
                objPro.nombre = txtNombre.Text;
                objPro.condicion = (this.Estado.Checked == true) ? true : false;
                objPro.IdCategoria = comboCat.SelectedValue.GetHashCode();
                objPro.descripcion = txtDescrip.Text;
                objPro.precio_venta = Convert.ToDecimal(txtPrecio.Text);

                try
                {
                    bll.Agregar(objPro);
                    MessageBox.Show("Se ha registrado un Nuevo Producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (btn_Guardar.Text == "Actualizar")
            {
                Articulo producto = bll.Buscar(Convert.ToInt32(txtIdPro.Text));
                producto.nombre = txtNombre.Text;
                producto.descripcion = txtDescrip.Text;
                producto.condicion = (this.Estado.Checked == true) ? true : false;
                producto.precio_venta = Convert.ToDecimal(txtPrecio.Text);
                try
                {
                    bll.Actualizar(producto); // Corrección: Debes pasar el objeto producto, no objPro
                    MessageBox.Show("Se ha Actualizado el Producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            Panel_Agregar.Visible = false;
            DataProducto.DataSource = bll.ListarProductos();
            this.btn_Actualizar.Enabled = true;
            this.btn_Nuevo.Enabled = true;
        }
        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            DataProducto.DataSource = bll.ListarProductosOrdenadosPorNombre(); 
            this.DataProducto.Columns[0].Width = 45;
            this.DataProducto.Columns[1].Width = 70;
            this.DataProducto.Columns[2].Width = 60;
            this.DataProducto.Columns[3].Width = 100;
            this.DataProducto.Columns[4].Width = 40;
            this.DataProducto.Columns[5].Width = 40;
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

