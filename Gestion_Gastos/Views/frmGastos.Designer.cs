namespace Gestion_Gastos_.Views
{
    partial class frmGastos
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
            panel1 = new Panel();
            cbxMetodoPago = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtMonto = new NumericUpDown();
            cbxCategoria = new ComboBox();
            txtDescripcion = new TextBox();
            label8 = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvTablaGastos = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvPanelTabla = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            lblTotal = new Label();
            label10 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtBuscar = new TextBox();
            label9 = new Label();
            estadoSistema = new StatusStrip();
            lblEstatus = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).BeginInit();
            dgvTablaGastos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanelTabla).BeginInit();
            panel4.SuspendLayout();
            estadoSistema.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxMetodoPago);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(cbxCategoria);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvTablaGastos);
            panel1.Location = new Point(9, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 443);
            panel1.TabIndex = 0;
            // 
            // cbxMetodoPago
            // 
            cbxMetodoPago.FormattingEnabled = true;
            cbxMetodoPago.Location = new Point(13, 371);
            cbxMetodoPago.Margin = new Padding(2);
            cbxMetodoPago.Name = "cbxMetodoPago";
            cbxMetodoPago.Size = new Size(244, 23);
            cbxMetodoPago.TabIndex = 13;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(13, 311);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(244, 23);
            dtpFecha.TabIndex = 12;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(13, 254);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(244, 23);
            txtMonto.TabIndex = 11;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(13, 200);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(244, 23);
            cbxCategoria.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 139);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(244, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 84);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 8;
            label8.Text = "REGISTRAR GASTOS";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Location = new Point(165, 411);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSeaGreen;
            btnGuardar.Location = new Point(33, 411);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 347);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 5;
            label7.Text = "Metodo de pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 293);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 4;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 236);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 3;
            label5.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 182);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Descripcion";
            // 
            // dgvTablaGastos
            // 
            dgvTablaGastos.BackColor = Color.Thistle;
            dgvTablaGastos.Controls.Add(label1);
            dgvTablaGastos.Location = new Point(0, 0);
            dgvTablaGastos.Name = "dgvTablaGastos";
            dgvTablaGastos.Size = new Size(311, 67);
            dgvTablaGastos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE GASTOS - REGISTROS";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPanelTabla);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(329, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 443);
            panel2.TabIndex = 1;
            // 
            // dgvPanelTabla
            // 
            dgvPanelTabla.AllowUserToDeleteRows = false;
            dgvPanelTabla.AllowUserToResizeRows = false;
            dgvPanelTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanelTabla.Location = new Point(3, 130);
            dgvPanelTabla.Margin = new Padding(2);
            dgvPanelTabla.Name = "dgvPanelTabla";
            dgvPanelTabla.RowHeadersWidth = 62;
            dgvPanelTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanelTabla.Size = new Size(358, 156);
            dgvPanelTabla.TabIndex = 7;
            dgvPanelTabla.DoubleClick += dgvPanelTabla_DoubleClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 67);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 21);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "GASTOS REGISTRADOS";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(71, 395);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "....";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 395);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 5;
            label10.Text = "Total :";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(214, 323);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.PaleGoldenrod;
            btnEditar.Location = new Point(80, 323);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(71, 93);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(160, 23);
            txtBuscar.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 96);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 0;
            label9.Text = "Buscar:";
            // 
            // estadoSistema
            // 
            estadoSistema.ImageScalingSize = new Size(24, 24);
            estadoSistema.Items.AddRange(new ToolStripItem[] { lblEstatus });
            estadoSistema.Location = new Point(0, 453);
            estadoSistema.Name = "estadoSistema";
            estadoSistema.Padding = new Padding(1, 0, 10, 0);
            estadoSistema.Size = new Size(729, 22);
            estadoSistema.TabIndex = 2;
            estadoSistema.Text = "statusStrip1";
            // 
            // lblEstatus
            // 
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(19, 17);
            lblEstatus.Text = "....";
            // 
            // frmGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 475);
            Controls.Add(estadoSistema);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmGastos";
            Text = "frmGastos";
            Load += frmGastos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMonto).EndInit();
            dgvTablaGastos.ResumeLayout(false);
            dgvTablaGastos.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanelTabla).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            estadoSistema.ResumeLayout(false);
            estadoSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel dgvTablaGastos;
        private Panel panel2;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cbxCategoria;
        private TextBox txtDescripcion;
        private Label label8;
        private Button btnLimpiar;
        private Button btnGuardar;
        private DateTimePicker dtpFecha;
        private NumericUpDown txtMonto;
        private Label lblTotal;
        private Label label10;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtBuscar;
        private Label label9;
        private ComboBox cbxMetodoPago;
        private StatusStrip estadoSistema;
        private ToolStripStatusLabel lblEstatus;
        private DataGridView dgvPanelTabla;
    }
}