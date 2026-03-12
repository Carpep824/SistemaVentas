using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmListadoProducto()
        {
            InitializeComponent();
        }

        private void FrmListadoProducto_Load_1(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            Mostrar();
        }

        //Metodo para mostrar los registros en el DataGridView
        public void Mostrar()
        {
            this.dlistado.DataSource = CNProducto.Listar();
        }

        //Metodo para buscar clientes por nombre
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNProducto.BuscarNombre(this.txtbuscar.Text);
        }

        //Metodo para buscar clientes por DNI
        public void BuscarCodigo()
        {
            this.dlistado.DataSource = CNProducto.BuscarCodigo(this.txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtncodigo.Checked)
            {
                BuscarCodigo();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto form = new FrmRegistrarProducto();

            form.Show();
            form.Insert = true;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto form = new FrmRegistrarProducto();
            form.Edit = true;

            form.txtidproducto.Text = this.dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
            form.txtcodigo.Text = this.dlistado.CurrentRow.Cells["codigo"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();
            form.dtfechaingreso.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_ingreso"].Value.ToString());
            form.dtfechavencimiento.Value = Convert.ToDateTime(this.dlistado.CurrentRow.Cells["f_vencimiento"].Value.ToString());
            form.txtpreciocompra.Text = this.dlistado.CurrentRow.Cells["precio_compra"].Value.ToString();
            form.txtprecioventa.Text = this.dlistado.CurrentRow.Cells["precio_venta"].Value.ToString();
            form.txtcantidad.Text = this.dlistado.CurrentRow.Cells["stock"].Value.ToString();
            form.cboidcategoria.Text = this.dlistado.CurrentRow.Cells["categoria"].Value.ToString();

            string estado = this.dlistado.CurrentRow.Cells["estado"].Value.ToString();

            if (estado == "ACTIVO")
            {
                form.rbactivo.Checked = true;
            }
            else
            {
                form.rbinactivo.Checked = true;
            }
            form.ShowDialog();
            this.Mostrar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Realmente desea eliminar el(los) registro(s)?",
                    "Sistema de Ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idproducto = dlistado.CurrentRow.Cells["idproducto"].Value.ToString();
                        CNCliente.Eliminar(Convert.ToInt32(idproducto));

                        MessageBox.Show("Registro(s) eliminado(s) correctamente",
                            "Sistema de Ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Mostrar();
                    }
                }
                Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
