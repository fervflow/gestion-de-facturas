namespace SistemaFactura
{
    partial class RegistrarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarFactura));
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            lbTitulo = new Label();
            tbNit = new TextBox();
            tbAutorizacion = new TextBox();
            dtFecha = new DateTimePicker();
            tbMontoTotal = new TextBox();
            tbMontoImponible = new TextBox();
            tbCodigoControl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btRegistrar = new Button();
            tbNombreUsuario = new TextBox();
            tbNitUsuario = new TextBox();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lab = new Label();
            tbNumFactura = new TextBox();
            tbRazonSocial = new Label();
            tbNombreRazon = new TextBox();
            gbTipoDescargo = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            rbTrimestral = new RadioButton();
            rbMensual = new RadioButton();
            cbMontoImponible = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTipoDescargo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lbTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 42);
            panel1.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Orange;
            lbTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = SystemColors.ControlLightLight;
            lbTitulo.Location = new Point(12, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(167, 25);
            lbTitulo.TabIndex = 20;
            lbTitulo.Text = "Registrar Factura:";
            // 
            // tbNit
            // 
            tbNit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNit.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbNit.Location = new Point(336, 81);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(214, 25);
            tbNit.TabIndex = 0;
            tbNit.KeyPress += tbNit_KeyPress;
            // 
            // tbAutorizacion
            // 
            tbAutorizacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbAutorizacion.CharacterCasing = CharacterCasing.Upper;
            tbAutorizacion.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbAutorizacion.Location = new Point(336, 166);
            tbAutorizacion.Multiline = true;
            tbAutorizacion.Name = "tbAutorizacion";
            tbAutorizacion.Size = new Size(214, 48);
            tbAutorizacion.TabIndex = 2;
            tbAutorizacion.KeyPress += tbAutorizacion_KeyPress;
            // 
            // dtFecha
            // 
            dtFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtFecha.Location = new Point(337, 299);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(213, 23);
            dtFecha.TabIndex = 4;
            // 
            // tbMontoTotal
            // 
            tbMontoTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMontoTotal.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbMontoTotal.Location = new Point(337, 345);
            tbMontoTotal.Name = "tbMontoTotal";
            tbMontoTotal.Size = new Size(213, 25);
            tbMontoTotal.TabIndex = 5;
            tbMontoTotal.TextAlign = HorizontalAlignment.Right;
            tbMontoTotal.TextChanged += tbMontoTotal_TextChanged;
            tbMontoTotal.Enter += tbMoney_Enter;
            tbMontoTotal.KeyDown += tbMoney_KeyDown;
            tbMontoTotal.KeyPress += tbMoney_KeyPress;
            // 
            // tbMontoImponible
            // 
            tbMontoImponible.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMontoImponible.Enabled = false;
            tbMontoImponible.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbMontoImponible.Location = new Point(337, 387);
            tbMontoImponible.Name = "tbMontoImponible";
            tbMontoImponible.ReadOnly = true;
            tbMontoImponible.Size = new Size(213, 25);
            tbMontoImponible.TabIndex = 6;
            tbMontoImponible.TextAlign = HorizontalAlignment.Right;
            tbMontoImponible.Enter += tbMoney_Enter;
            tbMontoImponible.KeyDown += tbMoney_KeyDown;
            tbMontoImponible.KeyPress += tbMoney_KeyPress;
            // 
            // tbCodigoControl
            // 
            tbCodigoControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCodigoControl.CharacterCasing = CharacterCasing.Upper;
            tbCodigoControl.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbCodigoControl.Location = new Point(337, 432);
            tbCodigoControl.Name = "tbCodigoControl";
            tbCodigoControl.Size = new Size(213, 25);
            tbCodigoControl.TabIndex = 7;
            tbCodigoControl.TextChanged += tbCodigoControl_TextChanged;
            tbCodigoControl.KeyPress += tbCodigoControl_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(257, 83);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 8;
            label1.Text = "NIT/CI:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(168, 168);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 9;
            label2.Text = "Codigo Autorización:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(189, 301);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 10;
            label3.Text = "Fecha de Emisión:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(227, 343);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 11;
            label4.Text = "Monto Total:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(189, 389);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 12;
            label5.Text = "Monto Imponible:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(195, 430);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 13;
            label6.Text = "Código Control:";
            // 
            // btRegistrar
            // 
            btRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btRegistrar.BackColor = Color.FromArgb(0, 17, 61);
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.Font = new Font("Segoe UI", 11F);
            btRegistrar.ForeColor = SystemColors.ControlLightLight;
            btRegistrar.Location = new Point(270, 569);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(145, 33);
            btRegistrar.TabIndex = 10;
            btRegistrar.Text = "Registrar Factura";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNombreUsuario.CharacterCasing = CharacterCasing.Upper;
            tbNombreUsuario.Enabled = false;
            tbNombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tbNombreUsuario.Location = new Point(146, 8);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.ReadOnly = true;
            tbNombreUsuario.Size = new Size(237, 27);
            tbNombreUsuario.TabIndex = 15;
            // 
            // tbNitUsuario
            // 
            tbNitUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNitUsuario.Enabled = false;
            tbNitUsuario.Font = new Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold);
            tbNitUsuario.Location = new Point(458, 9);
            tbNitUsuario.Name = "tbNitUsuario";
            tbNitUsuario.ReadOnly = true;
            tbNitUsuario.Size = new Size(129, 25);
            tbNitUsuario.TabIndex = 16;
            tbNitUsuario.TextChanged += tbNitUsuario_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(63, 5);
            label7.Name = "label7";
            label7.Size = new Size(77, 33);
            label7.TabIndex = 17;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(389, 5);
            label8.Name = "label8";
            label8.Size = new Size(63, 33);
            label8.TabIndex = 18;
            label8.Text = "NIT/CI:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.AppWorkspace;
            label10.Location = new Point(617, 45);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 21;
            label10.Text = "JEELM©2024";
            // 
            // lab
            // 
            lab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 12F);
            lab.Location = new Point(189, 122);
            lab.Name = "lab";
            lab.Size = new Size(125, 21);
            lab.TabIndex = 25;
            lab.Text = "Numero Factura:";
            // 
            // tbNumFactura
            // 
            tbNumFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNumFactura.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbNumFactura.Location = new Point(337, 122);
            tbNumFactura.MaxLength = 6;
            tbNumFactura.Name = "tbNumFactura";
            tbNumFactura.Size = new Size(213, 25);
            tbNumFactura.TabIndex = 1;
            tbNumFactura.KeyPress += tbNumFactura_KeyPress;
            // 
            // tbRazonSocial
            // 
            tbRazonSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRazonSocial.AutoSize = true;
            tbRazonSocial.Font = new Font("Segoe UI", 12F);
            tbRazonSocial.Location = new Point(149, 234);
            tbRazonSocial.Name = "tbRazonSocial";
            tbRazonSocial.Size = new Size(176, 21);
            tbRazonSocial.TabIndex = 27;
            tbRazonSocial.Text = "Nombre o Razon Social:";
            // 
            // tbNombreRazon
            // 
            tbNombreRazon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNombreRazon.CharacterCasing = CharacterCasing.Upper;
            tbNombreRazon.Location = new Point(337, 232);
            tbNombreRazon.Multiline = true;
            tbNombreRazon.Name = "tbNombreRazon";
            tbNombreRazon.Size = new Size(213, 45);
            tbNombreRazon.TabIndex = 3;
            tbNombreRazon.KeyPress += tbNombreRazon_KeyPress;
            // 
            // gbTipoDescargo
            // 
            gbTipoDescargo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbTipoDescargo.Controls.Add(label11);
            gbTipoDescargo.Controls.Add(label12);
            gbTipoDescargo.Controls.Add(rbTrimestral);
            gbTipoDescargo.Controls.Add(rbMensual);
            gbTipoDescargo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbTipoDescargo.Location = new Point(149, 477);
            gbTipoDescargo.Name = "gbTipoDescargo";
            gbTipoDescargo.Size = new Size(470, 75);
            gbTipoDescargo.TabIndex = 28;
            gbTipoDescargo.TabStop = false;
            gbTipoDescargo.Text = "Tipo de Descargo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(37, 52);
            label11.Name = "label11";
            label11.Size = new Size(157, 15);
            label11.TabIndex = 30;
            label11.Text = "*Sirve para el Formulario 200";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(294, 52);
            label12.Name = "label12";
            label12.Size = new Size(157, 15);
            label12.TabIndex = 31;
            label12.Text = "*Sirve para el Formulario 500";
            // 
            // rbTrimestral
            // 
            rbTrimestral.AutoSize = true;
            rbTrimestral.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbTrimestral.Location = new Point(294, 25);
            rbTrimestral.Name = "rbTrimestral";
            rbTrimestral.Size = new Size(98, 24);
            rbTrimestral.TabIndex = 9;
            rbTrimestral.TabStop = true;
            rbTrimestral.Text = "Trimestral";
            rbTrimestral.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            rbMensual.AutoSize = true;
            rbMensual.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbMensual.Location = new Point(37, 25);
            rbMensual.Name = "rbMensual";
            rbMensual.Size = new Size(86, 24);
            rbMensual.TabIndex = 8;
            rbMensual.TabStop = true;
            rbMensual.Text = "Mensual";
            rbMensual.UseVisualStyleBackColor = true;
            // 
            // cbMontoImponible
            // 
            cbMontoImponible.AutoSize = true;
            cbMontoImponible.BackColor = SystemColors.Control;
            cbMontoImponible.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cbMontoImponible.ForeColor = SystemColors.ControlText;
            cbMontoImponible.Location = new Point(562, 394);
            cbMontoImponible.Name = "cbMontoImponible";
            cbMontoImponible.Size = new Size(15, 14);
            cbMontoImponible.TabIndex = 29;
            cbMontoImponible.UseVisualStyleBackColor = false;
            cbMontoImponible.CheckedChanged += cbMontoImponible_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Orange;
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(tbNombreUsuario);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(tbNitUsuario);
            flowLayoutPanel1.Location = new Point(0, 619);
            flowLayoutPanel1.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(60, 5, 5, 5);
            flowLayoutPanel1.Size = new Size(714, 41);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // RegistrarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(714, 661);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbMontoImponible);
            Controls.Add(gbTipoDescargo);
            Controls.Add(tbRazonSocial);
            Controls.Add(tbNombreRazon);
            Controls.Add(lab);
            Controls.Add(tbNumFactura);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(btRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCodigoControl);
            Controls.Add(tbMontoImponible);
            Controls.Add(tbMontoTotal);
            Controls.Add(dtFecha);
            Controls.Add(tbAutorizacion);
            Controls.Add(tbNit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(730, 700);
            MinimumSize = new Size(730, 700);
            Name = "RegistrarFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Factura";
            Load += RegistrarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTipoDescargo.ResumeLayout(false);
            gbTipoDescargo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox tbNit;
        private Panel panel1;
        private Label label1;
        private TextBox tbCodigoControl;
        private TextBox tbMontoImponible;
        private TextBox tbMontoTotal;
        private DateTimePicker dtFecha;
        private TextBox tbAutorizacion;
        private TextBox tbNitUsuario;
        private Label label8;
        private TextBox tbNombreUsuario;
        private Label label7;
        private Button btRegistrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbTitulo;
        private Label label10;
        private Label lab;
        private TextBox tbNumFactura;
        private Label tbRazonSocial;
        private TextBox tbNombreRazon;
        private GroupBox gbTipoDescargo;
        private RadioButton rbTrimestral;
        private RadioButton rbMensual;
        private CheckBox cbMontoImponible;
        private Label label12;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}