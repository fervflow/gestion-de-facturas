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
            dataGridView1 = new DataGridView();
            nombre_razon = new DataGridViewTextBoxColumn();
            nit_emisor = new DataGridViewTextBoxColumn();
            numero_factura = new DataGridViewTextBoxColumn();
            cod_autorizacion = new DataGridViewTextBoxColumn();
            fecha_emision = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            monto_imponible = new DataGridViewTextBoxColumn();
            cod_control = new DataGridViewTextBoxColumn();
            tipo_descargo = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre_razon, nit_emisor, numero_factura, cod_autorizacion, fecha_emision, monto, monto_imponible, cod_control, tipo_descargo });
            dataGridView1.Location = new Point(0, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(786, 459);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre_razon
            // 
            nombre_razon.HeaderText = "Nombre/Razón";
            nombre_razon.Name = "nombre_razon";
            nombre_razon.ReadOnly = true;
            // 
            // nit_emisor
            // 
            nit_emisor.HeaderText = "NIT";
            nit_emisor.Name = "nit_emisor";
            nit_emisor.ReadOnly = true;
            // 
            // numero_factura
            // 
            numero_factura.HeaderText = "Nro. Factura";
            numero_factura.Name = "numero_factura";
            numero_factura.ReadOnly = true;
            // 
            // cod_autorizacion
            // 
            cod_autorizacion.HeaderText = "Cod. Autorización";
            cod_autorizacion.Name = "cod_autorizacion";
            cod_autorizacion.ReadOnly = true;
            // 
            // fecha_emision
            // 
            fecha_emision.HeaderText = "Fecha Emisión";
            fecha_emision.Name = "fecha_emision";
            fecha_emision.ReadOnly = true;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // monto_imponible
            // 
            monto_imponible.HeaderText = "Monto Imponible";
            monto_imponible.Name = "monto_imponible";
            monto_imponible.ReadOnly = true;
            // 
            // cod_control
            // 
            cod_control.HeaderText = "Cod. Control";
            cod_control.Name = "cod_control";
            cod_control.ReadOnly = true;
            // 
            // tipo_descargo
            // 
            tipo_descargo.HeaderText = "Tipo Descargo";
            tipo_descargo.Name = "tipo_descargo";
            tipo_descargo.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 61);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(317, 26);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipo:";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(605, 14);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 2;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(373, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 0;
            // 
            // ListarFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 529);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ListarFacturas";
            Text = "ListarFacturas";
            Load += ListarFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
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