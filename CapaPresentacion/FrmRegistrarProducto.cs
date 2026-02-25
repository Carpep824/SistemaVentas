using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {
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
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = rbtnactivo.Checked ? "ACTIVO" : "INACTIVO";

            try
            {
                if (string.IsNullOrWhiteSpace(this.txtnombre.Text) || string.IsNullOrWhiteSpace(this.txtcodigo.Text))
                {
                    MessageBox.Show("Ingrese los datos del producto", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert)
                    {
                        // CORRECCIÓN: Se agregan conversiones y el parámetro faltante (descripcion)
                        CNProducto.Guardar(
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtnombre.Text, // Enviamos el nombre como descripción temporalmente
                            Convert.ToDateTime(this.txtf_ingreso.Text),
                            Convert.ToDateTime(this.txtf_vencimiento.Text),
                            Convert.ToDouble(this.txtprecio_compra.Text),
                            Convert.ToDouble(this.txtprecio_venta.Text),
                            Convert.ToInt32(this.txtstock.Text),
                            estado,
                            Convert.ToInt32(this.txtidcategoria.Text) // idcategoria al final como pide tu clase
                        );

                        MessageBox.Show("Producto registrado correctamente");
                    }
                    else if (this.Edit)
                    {
                        CNProducto.Editar(
                            Convert.ToInt32(this.txtidproducto.Text),
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtnombre.Text,
                            Convert.ToDateTime(this.txtf_ingreso.Text),
                            Convert.ToDateTime(this.txtf_vencimiento.Text),
                            Convert.ToDouble(this.txtprecio_compra.Text),
                            Convert.ToDouble(this.txtprecio_venta.Text),
                            Convert.ToInt32(this.txtstock.Text),
                            estado,
                            Convert.ToInt32(this.txtidcategoria.Text)
                        );

                        MessageBox.Show("Producto editado correctamente");
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
                MessageBox.Show("Asegúrese de que las fechas y precios tengan el formato correcto.\n\nError: " + ex.Message);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
        }

        private void FrmRegistrarProducto_Load_1(object sender, EventArgs e)
        {

        }
    }

}