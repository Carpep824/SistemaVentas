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
            LlenarCategorias();
        }

        private void LlenarCategorias()
        {
            try
            {
                txtidcategoria.DataSource = CNCategoria.Listar();
                txtidcategoria.DisplayMember = "nombre";
                txtidcategoria.ValueMember = "idcategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            // Determinar el estado basándose en los RadioButtons
            string estado = rbtnactivo.Checked ? "ACTIVO" : "INACTIVO";

            try
            {
                // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(this.txtnombre.Text) || string.IsNullOrWhiteSpace(this.txtcodigo.Text))
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.Insert)
                {
                    string rpta = CNProducto.Guardar(
                        this.txtcodigo.Text.Trim(),
                        this.txtnombre.Text.Trim(),
                        this.txtdescripcion.Text.Trim(),
                        dtpfecha_ingreso.Value,
                        dtpfecha_vencimiento.Value,
                        Convert.ToDouble(this.txtprecio_compra.Text),
                        Convert.ToDouble(this.txtprecio_venta.Text),
                        Convert.ToInt32(this.txtstock.Text),
                        estado,
                        Convert.ToInt32(this.txtidcategoria.SelectedValue)
                    );

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Guardado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar: " + rpta);
                    }
                }
                else if (this.Edit)
                {
                    string rpta = CNProducto.Editar(
                        Convert.ToInt32(this.txtidproducto.Text),
                        this.txtcodigo.Text.Trim(),
                        this.txtnombre.Text.Trim(),
                        this.txtdescripcion.Text.Trim(),
                        dtpfecha_ingreso.Value,
                        dtpfecha_vencimiento.Value,
                        Convert.ToDouble(this.txtprecio_compra.Text),
                        Convert.ToDouble(this.txtprecio_venta.Text),
                        Convert.ToInt32(this.txtstock.Text),
                        estado,
                        Convert.ToInt32(this.txtidcategoria.SelectedValue)
                    );

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Producto editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Finalizar y regresar al listado
                FinalizarProceso();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifique que los precios y el stock sean números válidos.\n\n" + ex.Message);
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
            this.Close();
        }

    }
}