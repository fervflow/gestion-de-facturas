﻿namespace SistemaFactura
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
            label9 = new Label();
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lab = new Label();
            tbNumFactura = new TextBox();
            tbRazonSocial = new Label();
            tbNombreRazon = new TextBox();
            gbTipoDescargo = new GroupBox();
            rbTrimestral = new RadioButton();
            rbMensual = new RadioButton();
            cbMontoImponible = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTipoDescargo.SuspendLayout();
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
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 72);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Orange;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 20;
            label9.Text = "Factura:";
            // 
            // tbNit
            // 
            tbNit.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbNit.Location = new Point(336, 110);
            tbNit.Name = "tbNit";
            tbNit.Size = new Size(248, 25);
            tbNit.TabIndex = 0;
            tbNit.KeyPress += tbNit_KeyPress;
            // 
            // tbAutorizacion
            // 
            tbAutorizacion.CharacterCasing = CharacterCasing.Upper;
            tbAutorizacion.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbAutorizacion.Location = new Point(336, 195);
            tbAutorizacion.Multiline = true;
            tbAutorizacion.Name = "tbAutorizacion";
            tbAutorizacion.Size = new Size(248, 48);
            tbAutorizacion.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(337, 328);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(247, 23);
            dtFecha.TabIndex = 4;
            // 
            // tbMontoTotal
            // 
            tbMontoTotal.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbMontoTotal.Location = new Point(337, 374);
            tbMontoTotal.Name = "tbMontoTotal";
            tbMontoTotal.Size = new Size(247, 25);
            tbMontoTotal.TabIndex = 5;
            tbMontoTotal.TextChanged += tbMontoTotal_TextChanged;
            tbMontoTotal.Enter += tbMoney_Enter;
            tbMontoTotal.KeyDown += tbMoney_KeyDown;
            tbMontoTotal.KeyPress += tbMoney_KeyPress;
            // 
            // tbMontoImponible
            // 
            tbMontoImponible.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbMontoImponible.Location = new Point(337, 416);
            tbMontoImponible.Name = "tbMontoImponible";
            tbMontoImponible.Size = new Size(247, 25);
            tbMontoImponible.TabIndex = 6;
            // 
            // tbCodigoControl
            // 
            tbCodigoControl.CharacterCasing = CharacterCasing.Upper;
            tbCodigoControl.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbCodigoControl.Location = new Point(337, 461);
            tbCodigoControl.Name = "tbCodigoControl";
            tbCodigoControl.Size = new Size(247, 25);
            tbCodigoControl.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(257, 112);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 8;
            label1.Text = "NIT/CI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(168, 197);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 9;
            label2.Text = "Codigo Autorización:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(189, 330);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 10;
            label3.Text = "Fecha de Emisión:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(227, 372);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 11;
            label4.Text = "Monto Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(189, 418);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 12;
            label5.Text = "Monto Imponible:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(195, 459);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 13;
            label6.Text = "Código Control:";
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = Color.FromArgb(0, 17, 61);
            btRegistrar.FlatAppearance.BorderSize = 0;
            btRegistrar.FlatStyle = FlatStyle.Flat;
            btRegistrar.Font = new Font("Segoe UI", 11F);
            btRegistrar.ForeColor = SystemColors.ControlLightLight;
            btRegistrar.Location = new Point(322, 608);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(143, 33);
            btRegistrar.TabIndex = 10;
            btRegistrar.Text = "Registrar Factura";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.CharacterCasing = CharacterCasing.Upper;
            tbNombreUsuario.Location = new Point(122, 5);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.ReadOnly = true;
            tbNombreUsuario.Size = new Size(222, 23);
            tbNombreUsuario.TabIndex = 15;
            // 
            // tbNitUsuario
            // 
            tbNitUsuario.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbNitUsuario.Location = new Point(442, 5);
            tbNitUsuario.Name = "tbNitUsuario";
            tbNitUsuario.ReadOnly = true;
            tbNitUsuario.Size = new Size(211, 25);
            tbNitUsuario.TabIndex = 16;
            tbNitUsuario.TextChanged += tbNitUsuario_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(35, 7);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 17;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(378, 9);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 18;
            label8.Text = "NIT/CI:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(tbNitUsuario);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbNombreUsuario);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 715);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 34);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 608);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.AppWorkspace;
            label10.Location = new Point(639, 75);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 21;
            label10.Text = "JEELM©2024";
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Segoe UI", 12F);
            lab.Location = new Point(189, 151);
            lab.Name = "lab";
            lab.Size = new Size(125, 21);
            lab.TabIndex = 25;
            lab.Text = "Numero Factura:";
            // 
            // tbNumFactura
            // 
            tbNumFactura.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold);
            tbNumFactura.Location = new Point(337, 151);
            tbNumFactura.Name = "tbNumFactura";
            tbNumFactura.Size = new Size(247, 25);
            tbNumFactura.TabIndex = 1;
            // 
            // tbRazonSocial
            // 
            tbRazonSocial.AutoSize = true;
            tbRazonSocial.Font = new Font("Segoe UI", 12F);
            tbRazonSocial.Location = new Point(149, 263);
            tbRazonSocial.Name = "tbRazonSocial";
            tbRazonSocial.Size = new Size(176, 21);
            tbRazonSocial.TabIndex = 27;
            tbRazonSocial.Text = "Nombre o Razon Social:";
            // 
            // tbNombreRazon
            // 
            tbNombreRazon.CharacterCasing = CharacterCasing.Upper;
            tbNombreRazon.Location = new Point(337, 261);
            tbNombreRazon.Multiline = true;
            tbNombreRazon.Name = "tbNombreRazon";
            tbNombreRazon.Size = new Size(247, 45);
            tbNombreRazon.TabIndex = 3;
            // 
            // gbTipoDescargo
            // 
            gbTipoDescargo.Controls.Add(label11);
            gbTipoDescargo.Controls.Add(label12);
            gbTipoDescargo.Controls.Add(rbTrimestral);
            gbTipoDescargo.Controls.Add(rbMensual);
            gbTipoDescargo.Font = new Font("Segoe UI", 11F);
            gbTipoDescargo.Location = new Point(131, 513);
            gbTipoDescargo.Name = "gbTipoDescargo";
            gbTipoDescargo.Size = new Size(563, 75);
            gbTipoDescargo.TabIndex = 28;
            gbTipoDescargo.TabStop = false;
            gbTipoDescargo.Text = "Tipo de Descargo:";
            // 
            // rbTrimestral
            // 
            rbTrimestral.AutoSize = true;
            rbTrimestral.Location = new Point(360, 26);
            rbTrimestral.Name = "rbTrimestral";
            rbTrimestral.Size = new Size(92, 24);
            rbTrimestral.TabIndex = 9;
            rbTrimestral.TabStop = true;
            rbTrimestral.Text = "Trimestral";
            rbTrimestral.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            rbMensual.AutoSize = true;
            rbMensual.Location = new Point(95, 26);
            rbMensual.Name = "rbMensual";
            rbMensual.Size = new Size(82, 24);
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
            cbMontoImponible.Location = new Point(590, 424);
            cbMontoImponible.Name = "cbMontoImponible";
            cbMontoImponible.Size = new Size(15, 14);
            cbMontoImponible.TabIndex = 29;
            cbMontoImponible.UseVisualStyleBackColor = false;
            cbMontoImponible.CheckedChanged += cbMontoImponible_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(96, 52);
            label11.Name = "label11";
            label11.Size = new Size(201, 20);
            label11.TabIndex = 30;
            label11.Text = "*Sirve para el Formulario 200";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(360, 52);
            label12.Name = "label12";
            label12.Size = new Size(201, 20);
            label12.TabIndex = 31;
            label12.Text = "*Sirve para el Formulario 500";
            // 
            // RegistrarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(717, 749);
            Controls.Add(cbMontoImponible);
            Controls.Add(gbTipoDescargo);
            Controls.Add(tbRazonSocial);
            Controls.Add(tbNombreRazon);
            Controls.Add(lab);
            Controls.Add(tbNumFactura);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Factura";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTipoDescargo.ResumeLayout(false);
            gbTipoDescargo.PerformLayout();
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
        private Panel panel2;
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
        private Label label9;
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
    }
}