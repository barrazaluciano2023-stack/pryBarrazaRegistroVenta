namespace pryBarrazaRegistroVenta
{
    partial class Principal
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
            txtProducto = new TextBox();
            lblfecha = new Label();
            lblProducto = new Label();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(295, 81);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(309, 29);
            dtpFecha.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 15.75F);
            txtPrecio.Location = new Point(295, 208);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 35);
            txtPrecio.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 15.75F);
            txtProducto.Location = new Point(295, 120);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 35);
            txtProducto.TabIndex = 2;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 15.75F);
            lblfecha.Location = new Point(118, 87);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(67, 30);
            lblfecha.TabIndex = 3;
            lblfecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15.75F);
            lblProducto.Location = new Point(118, 126);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(97, 30);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F);
            lblPrecio.Location = new Point(118, 214);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(149, 30);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 15.75F);
            txtCantidad.Location = new Point(295, 167);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 35);
            txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15.75F);
            lblCantidad.Location = new Point(118, 173);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(96, 30);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlDark;
            btnRegistrar.Location = new Point(295, 291);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 25);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(lblfecha);
            Controls.Add(txtProducto);
            Controls.Add(txtPrecio);
            Controls.Add(dtpFecha);
            Name = "Principal";
            Tag = "";
            Text = "Principal";
            Load += Principal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private Label lblfecha;
        private Label lblProducto;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnRegistrar;
    }
}