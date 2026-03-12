namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
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
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbinactivo = new System.Windows.Forms.RadioButton();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtfechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtfechaingreso = new System.Windows.Forms.DateTimePicker();
            this.cboidcategoria = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(217, 99);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 22);
            this.txtidproducto.TabIndex = 33;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(736, 422);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(630, 422);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // rbinactivo
            // 
            this.rbinactivo.AutoSize = true;
            this.rbinactivo.Location = new System.Drawing.Point(603, 317);
            this.rbinactivo.Name = "rbinactivo";
            this.rbinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbinactivo.TabIndex = 30;
            this.rbinactivo.TabStop = true;
            this.rbinactivo.Text = "Inactivo";
            this.rbinactivo.UseVisualStyleBackColor = true;
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Location = new System.Drawing.Point(493, 317);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(65, 20);
            this.rbactivo.TabIndex = 29;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(493, 193);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(271, 22);
            this.txtprecioventa.TabIndex = 28;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(493, 130);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(271, 22);
            this.txtpreciocompra.TabIndex = 27;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(40, 257);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(271, 22);
            this.txtdescripcion.TabIndex = 26;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(40, 194);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(271, 22);
            this.txtcodigo.TabIndex = 25;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(40, 130);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(271, 22);
            this.txtnombre.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seleccione estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio de venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio de compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Nuevo Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de vencimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha de ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Categoria";
            // 
            // dtfechavencimiento
            // 
            this.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechavencimiento.Location = new System.Drawing.Point(40, 383);
            this.dtfechavencimiento.Name = "dtfechavencimiento";
            this.dtfechavencimiento.Size = new System.Drawing.Size(109, 22);
            this.dtfechavencimiento.TabIndex = 42;
            // 
            // dtfechaingreso
            // 
            this.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaingreso.Location = new System.Drawing.Point(40, 317);
            this.dtfechaingreso.Name = "dtfechaingreso";
            this.dtfechaingreso.Size = new System.Drawing.Size(109, 22);
            this.dtfechaingreso.TabIndex = 43;
            // 
            // cboidcategoria
            // 
            this.cboidcategoria.FormattingEnabled = true;
            this.cboidcategoria.Location = new System.Drawing.Point(493, 385);
            this.cboidcategoria.Name = "cboidcategoria";
            this.cboidcategoria.Size = new System.Drawing.Size(271, 24);
            this.cboidcategoria.TabIndex = 45;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(493, 257);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(271, 22);
            this.txtcantidad.TabIndex = 46;
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 475);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cboidcategoria);
            this.Controls.Add(this.dtfechaingreso);
            this.Controls.Add(this.dtfechavencimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbinactivo);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbinactivo;
        public System.Windows.Forms.RadioButton rbactivo;
        public System.Windows.Forms.TextBox txtprecioventa;
        public System.Windows.Forms.TextBox txtpreciocompra;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.DateTimePicker dtfechavencimiento;
        public System.Windows.Forms.DateTimePicker dtfechaingreso;
        public System.Windows.Forms.ComboBox cboidcategoria;
    }
}