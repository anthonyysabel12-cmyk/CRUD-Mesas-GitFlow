namespace SistemaRestaurante
{
    partial class FrmMesas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumeroMesa = new Label();
            lblCapacidad = new Label();
            lblEstado = new Label();
            txtNumeroMesa = new TextBox();
            txtCapacidad = new TextBox();
            cboEstado = new ComboBox();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMesas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMesas).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroMesa
            // 
            lblNumeroMesa.AutoSize = true;
            lblNumeroMesa.Location = new Point(12, 32);
            lblNumeroMesa.Name = "lblNumeroMesa";
            lblNumeroMesa.Size = new Size(101, 15);
            lblNumeroMesa.TabIndex = 0;
            lblNumeroMesa.Text = "Número de Mesa:";
            lblNumeroMesa.Click += lblNumeroMesa_Click;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(12, 66);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(66, 15);
            lblCapacidad.TabIndex = 1;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(12, 95);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.BackColor = SystemColors.InactiveBorder;
            txtNumeroMesa.Location = new Point(147, 32);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(100, 23);
            txtNumeroMesa.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(147, 66);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 4;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(147, 95);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 5;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 156);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(105, 156);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Motrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 204);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(105, 204);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(193, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMesas
            // 
            dgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesas.Location = new Point(12, 263);
            dgvMesas.Name = "dgvMesas";
            dgvMesas.Size = new Size(497, 175);
            dgvMesas.TabIndex = 11;
            dgvMesas.CellContentClick += dgvMesas_CellContentClick;
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMesas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(cboEstado);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNumeroMesa);
            Controls.Add(lblEstado);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNumeroMesa);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmMesas";
            Text = "Gestión de Mesas";
            Load += FrmMesas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroMesa;
        private Label lblCapacidad;
        private Label lblEstado;
        private TextBox txtNumeroMesa;
        private TextBox txtCapacidad;
        private ComboBox cboEstado;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvMesas;
    }
}
