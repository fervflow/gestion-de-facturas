namespace SistemaFactura.Forms
{
    partial class ListarFacturas
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
            dgvListaFacturas = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            dtpFecha = new DateTimePicker();
            cbxTipo = new ComboBox();
            nombre_razon = new DataGridViewTextBoxColumn();
            nit_emisor = new DataGridViewTextBoxColumn();
            numero_factura = new DataGridViewTextBoxColumn();
            cod_autorizacion = new DataGridViewTextBoxColumn();
            fecha_emision = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            monto_imponible = new DataGridViewTextBoxColumn();
            cod_control = new DataGridViewTextBoxColumn();
            tipo_descargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListaFacturas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListaFacturas
            // 
            dgvListaFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaFacturas.Columns.AddRange(new DataGridViewColumn[] { nombre_razon, nit_emisor, numero_factura, cod_autorizacion, fecha_emision, monto, monto_imponible, cod_control, tipo_descargo });
            dgvListaFacturas.Location = new Point(12, 67);
            dgvListaFacturas.Name = "dgvListaFacturas";
            dgvListaFacturas.Size = new Size(944, 432);
            dgvListaFacturas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(cbxTipo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 61);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(380, 23);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(92, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipo:";
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(768, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(439, 21);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(226, 23);
            dtpFecha.TabIndex = 1;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(142, 20);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(163, 23);
            cbxTipo.TabIndex = 0;
            // 
            // nombre_razon
            // 
            nombre_razon.HeaderText = "Nombre/Razón";
            nombre_razon.Name = "nombre_razon";
            nombre_razon.ReadOnly = true;
            nombre_razon.Width = 180;
            // 
            // nit_emisor
            // 
            nit_emisor.HeaderText = "NIT";
            nit_emisor.Name = "nit_emisor";
            nit_emisor.ReadOnly = true;
            nit_emisor.Width = 70;
            // 
            // numero_factura
            // 
            numero_factura.HeaderText = "Nro. Factura";
            numero_factura.Name = "numero_factura";
            numero_factura.ReadOnly = true;
            // 
            // cod_autorizacion
            // 
            cod_autorizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cod_autorizacion.HeaderText = "Cod. Autorización";
            cod_autorizacion.Name = "cod_autorizacion";
            cod_autorizacion.ReadOnly = true;
            cod_autorizacion.Width = 116;
            // 
            // fecha_emision
            // 
            fecha_emision.HeaderText = "Fecha Emisión";
            fecha_emision.Name = "fecha_emision";
            fecha_emision.ReadOnly = true;
            fecha_emision.Width = 70;
            // 
            // monto
            // 
            monto.HeaderText = "Monto Bs.";
            monto.Name = "monto";
            monto.ReadOnly = true;
            monto.Width = 80;
            // 
            // monto_imponible
            // 
            monto_imponible.HeaderText = "Monto Imponible Bs.";
            monto_imponible.Name = "monto_imponible";
            monto_imponible.ReadOnly = true;
            monto_imponible.Width = 80;
            // 
            // cod_control
            // 
            cod_control.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cod_control.HeaderText = "Cod. Control";
            cod_control.Name = "cod_control";
            cod_control.ReadOnly = true;
            cod_control.Width = 92;
            // 
            // tipo_descargo
            // 
            tipo_descargo.HeaderText = "Tipo Descargo";
            tipo_descargo.Name = "tipo_descargo";
            tipo_descargo.ReadOnly = true;
            tipo_descargo.Width = 70;
            // 
            // ListarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 511);
            Controls.Add(panel1);
            Controls.Add(dgvListaFacturas);
            MinimumSize = new Size(984, 550);
            Name = "ListarFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarFacturas";
            ((System.ComponentModel.ISupportInitialize)dgvListaFacturas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaFacturas;
        private Panel panel1;
        private Label label1;
        private Button btnBuscar;
        private DateTimePicker dtpFecha;
        private ComboBox cbxTipo;
        private Label label2;
        private DataGridViewTextBoxColumn nombre_razon;
        private DataGridViewTextBoxColumn nit_emisor;
        private DataGridViewTextBoxColumn numero_factura;
        private DataGridViewTextBoxColumn cod_autorizacion;
        private DataGridViewTextBoxColumn fecha_emision;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn monto_imponible;
        private DataGridViewTextBoxColumn cod_control;
        private DataGridViewTextBoxColumn tipo_descargo;
    }
}