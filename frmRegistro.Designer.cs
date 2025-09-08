namespace pryBarrazaRegistroVenta
{
    partial class frmRegistro
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
            dtpFecha = new DateTimePicker();
            txtPrecio = new TextBox();
            lblfecha = new Label();
            lblProducto = new Label();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            cmbProducto = new ComboBox();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(256, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(246, 29);
            dtpFecha.TabIndex = 0;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(256, 154);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(246, 29);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 12F);
            lblfecha.Location = new Point(63, 27);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(50, 21);
            lblfecha.TabIndex = 3;
            lblfecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F);
            lblProducto.Location = new Point(63, 66);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 21);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(63, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(113, 21);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(256, 113);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(246, 29);
            txtCantidad.TabIndex = 6;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(63, 113);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDark;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(156, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlDark;
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(286, 246);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 31);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.TextChanged += Principal_Load;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 12F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(256, 76);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(247, 29);
            cmbProducto.TabIndex = 11;
            cmbProducto.SelectedIndexChanged += txtProducto_SelectedIndexChanged;
            // 
            // lblRegistro
            // 
            lblRegistro.BackColor = SystemColors.ControlLightLight;
            lblRegistro.Font = new Font("Segoe UI", 12F);
            lblRegistro.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistro.Location = new Point(100, 342);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(391, 78);
            lblRegistro.TabIndex = 12;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegistro);
            Controls.Add(cmbProducto);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(lblfecha);
            Controls.Add(txtPrecio);
            Controls.Add(dtpFecha);
            Name = "frmRegistro";
            Tag = "";
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrecio;
        private Label lblfecha;
        private Label lblProducto;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnCancelar;
        internal DateTimePicker dtpFecha;
        private Button button1;
        private Button btnRegistrar;
        private ComboBox cmbProducto;
        private Label lblRegistro;
    }
}