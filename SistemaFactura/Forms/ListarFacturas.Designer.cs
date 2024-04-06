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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cbTrimestral = new CheckBox();
            cbMensual = new CheckBox();
            lbFecha = new Label();
            lbIntervalo = new Label();
            btnBuscar = new Button();
            dtpFecha = new DateTimePicker();
            cbxTipo = new ComboBox();
            ttFecha = new ToolTip(components);
            tipo_descargo = new DataGridViewTextBoxColumn();
            cod_control = new DataGridViewTextBoxColumn();
            monto_imponible = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            fecha_emision = new DataGridViewTextBoxColumn();
            cod_autorizacion = new DataGridViewTextBoxColumn();
            numero_factura = new DataGridViewTextBoxColumn();
            nit_emisor = new DataGridViewTextBoxColumn();
            nombre_razon = new DataGridViewTextBoxColumn();
            dgvListaFacturas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaFacturas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(cbTrimestral);
            panel1.Controls.Add(cbMensual);
            panel1.Controls.Add(lbFecha);
            panel1.Controls.Add(lbIntervalo);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(cbxTipo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 61);
            panel1.TabIndex = 1;
            // 
            // cbTrimestral
            // 
            cbTrimestral.AutoSize = true;
            cbTrimestral.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbTrimestral.Location = new Point(752, 22);
            cbTrimestral.Name = "cbTrimestral";
            cbTrimestral.Size = new Size(99, 24);
            cbTrimestral.TabIndex = 6;
            cbTrimestral.Text = "Trimestral";
            cbTrimestral.UseVisualStyleBackColor = true;
            cbTrimestral.CheckedChanged += cbTrimestral_CheckedChanged;
            // 
            // cbMensual
            // 
            cbMensual.AutoSize = true;
            cbMensual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbMensual.Location = new Point(653, 22);
            cbMensual.Name = "cbMensual";
            cbMensual.Size = new Size(87, 24);
            cbMensual.TabIndex = 5;
            cbMensual.Text = "Mensual";
            cbMensual.UseVisualStyleBackColor = true;
            cbMensual.CheckedChanged += cbMensual_CheckedChanged;
            // 
            // lbFecha
            // 
            lbFecha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbFecha.Location = new Point(214, 23);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(158, 20);
            lbFecha.TabIndex = 4;
            lbFecha.Text = "Fecha:";
            lbFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbIntervalo
            // 
            lbIntervalo.AutoSize = true;
            lbIntervalo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbIntervalo.Location = new Point(23, 23);
            lbIntervalo.Name = "lbIntervalo";
            lbIntervalo.Size = new Size(77, 20);
            lbIntervalo.TabIndex = 3;
            lbIntervalo.Text = "Intérvalo:";
            lbIntervalo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(872, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 11F);
            dtpFecha.Location = new Point(373, 18);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(265, 27);
            dtpFecha.TabIndex = 1;
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.Font = new Font("Segoe UI", 11F);
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "DIA", "MES", "TRIMESTRE", "TODAS" });
            cbxTipo.Location = new Point(103, 18);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(100, 28);
            cbxTipo.TabIndex = 0;
            cbxTipo.SelectedIndexChanged += cbxTipo_SelectedIndexChanged;
            // 
            // ttFecha
            // 
            ttFecha.IsBalloon = true;
            ttFecha.ToolTipIcon = ToolTipIcon.Info;
            ttFecha.ToolTipTitle = "Seleccionar Fecha";
            // 
            // tipo_descargo
            // 
            tipo_descargo.HeaderText = "Tipo Descargo";
            tipo_descargo.Name = "tipo_descargo";
            tipo_descargo.ReadOnly = true;
            tipo_descargo.Width = 70;
            // 
            // cod_control
            // 
            cod_control.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cod_control.HeaderText = "Cod. Control";
            cod_control.Name = "cod_control";
            cod_control.ReadOnly = true;
            cod_control.Width = 92;
            // 
            // monto_imponible
            // 
            monto_imponible.HeaderText = "Monto Imponible Bs.";
            monto_imponible.Name = "monto_imponible";
            monto_imponible.ReadOnly = true;
            monto_imponible.Width = 80;
            // 
            // monto
            // 
            monto.HeaderText = "Monto Bs.";
            monto.Name = "monto";
            monto.ReadOnly = true;
            monto.Width = 80;
            // 
            // fecha_emision
            // 
            fecha_emision.HeaderText = "Fecha Emisión";
            fecha_emision.Name = "fecha_emision";
            fecha_emision.ReadOnly = true;
            // 
            // cod_autorizacion
            // 
            cod_autorizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cod_autorizacion.HeaderText = "Cod. Autorización";
            cod_autorizacion.Name = "cod_autorizacion";
            cod_autorizacion.ReadOnly = true;
            cod_autorizacion.Width = 116;
            // 
            // numero_factura
            // 
            numero_factura.HeaderText = "Nro. Factura";
            numero_factura.Name = "numero_factura";
            numero_factura.ReadOnly = true;
            // 
            // nit_emisor
            // 
            nit_emisor.HeaderText = "NIT";
            nit_emisor.Name = "nit_emisor";
            nit_emisor.ReadOnly = true;
            nit_emisor.Width = 90;
            // 
            // nombre_razon
            // 
            nombre_razon.HeaderText = "Nombre/Razón";
            nombre_razon.Name = "nombre_razon";
            nombre_razon.ReadOnly = true;
            nombre_razon.Width = 180;
            // 
            // dgvListaFacturas
            // 
            dgvListaFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaFacturas.Columns.AddRange(new DataGridViewColumn[] { nombre_razon, nit_emisor, numero_factura, cod_autorizacion, fecha_emision, monto, monto_imponible, cod_control, tipo_descargo });
            dgvListaFacturas.Location = new Point(12, 67);
            dgvListaFacturas.Name = "dgvListaFacturas";
            dgvListaFacturas.ReadOnly = true;
            dgvListaFacturas.Size = new Size(960, 471);
            dgvListaFacturas.TabIndex = 0;
            // 
            // ListarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 550);
            Controls.Add(panel1);
            Controls.Add(dgvListaFacturas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(984, 550);
            Name = "ListarFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarFacturas";
            Load += ListarFacturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaFacturas;
        private Panel panel1;
        private Label lbIntervalo;
        private Button btnBuscar;
        private DateTimePicker dtpFecha;
        private ComboBox cbxTipo;
        private Label lbFecha;
        private DataGridViewTextBoxColumn nombre_razon;
        private DataGridViewTextBoxColumn nit_emisor;
        private DataGridViewTextBoxColumn numero_factura;
        private DataGridViewTextBoxColumn cod_autorizacion;
        private DataGridViewTextBoxColumn fecha_emision;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn monto_imponible;
        private DataGridViewTextBoxColumn cod_control;
        private DataGridViewTextBoxColumn tipo_descargo;
        private ToolTip ttFecha;
        private CheckBox cbTrimestral;
        private CheckBox cbMensual;
    }
}