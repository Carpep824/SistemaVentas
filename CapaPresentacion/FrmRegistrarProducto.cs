using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {
        // Variables para determinar la acción del formulario
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            // Llenar el ComboBox de categorías al iniciar
            this.CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                cboidcategoria.DataSource = CNCategoria.Listar();
                cboidcategoria.ValueMember = "idcategoria";
                cboidcategoria.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string estado = rbactivo.Checked ? "ACTIVO" : "INACTIVO";

            try
            {
                if (this.txtcodigo.Text == string.Empty || this.txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto", "sistema de ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(this.txtcodigo.Text,
                                            this.txtnombre.Text,
                                            this.txtdescripcion.Text,
                                            this.dtfechaingreso.Value,
                                            this.dtfechavencimiento.Value,
                                            Convert.ToDouble(this.txtpreciocompra.Text),
                                            Convert.ToDouble(this.txtprecioventa.Text),
                                            Convert.ToInt32(this.txtcantidad.Text),
                                            estado,
                                            Convert.ToInt32(this.cboidcategoria.SelectedValue));
                        MessageBox.Show("PRODUCTO REGISTRADO CORRECTAMENTE", "sistema de ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {

                        CNProducto.Editar(Convert.ToInt32(this.txtidproducto.Text),
                                                        this.txtcodigo.Text,
                                                        this.txtnombre.Text,
                                                        this.txtdescripcion.Text,
                                                        this.dtfechaingreso.Value,
                                                        this.dtfechavencimiento.Value,
                                                        Convert.ToDouble(this.txtpreciocompra.Text),
                                                        Convert.ToDouble(this.txtprecioventa.Text),
                                                        Convert.ToInt32(this.txtcantidad.Text),
                                                        estado,
                                                        Convert.ToInt32(this.cboidcategoria.SelectedValue));
                        MessageBox.Show("Producto editado correctamente", "sistema de ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoProducto form = new FrmListadoProducto();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void FinalizarProceso()
        {
            this.Insert = false;
            this.Edit = false;
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Close(); // Cerramos el formulario actual
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
        }

    }
}