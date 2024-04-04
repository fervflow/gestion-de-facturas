namespace SistemaFactura
{
    partial class RegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
            lbWarninig = new Label();
            lbNombreRazon = new Label();
            tbNombreRazon = new TextBox();
            btRegistrarse = new Button();
            label3 = new Label();
            btVolver = new Button();
            panel1 = new Panel();
            lbNitConfirm = new Label();
            tbNit = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbWarninig
            // 
            lbWarninig.AutoSize = true;
            lbWarninig.BackColor = Color.Orange;
            lbWarninig.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWarninig.Location = new Point(3, 9);
            lbWarninig.Name = "lbWarninig";
            lbWarninig.Size = new Size(445, 20);
            lbWarninig.TabIndex = 10;
            lbWarninig.Text = "Es la primera vez que ingresas a este sistema, por favor ingresa tu:";
            // 
            // lbNombreRazon
            // 
            lbNombreRazon.AutoSize = true;
            lbNombreRazon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbNombreRazon.Location = new Point(143, 60);
            lbNombreRazon.Name = "lbNombreRazon";
            lbNombreRazon.Size = new Size(185, 21);
            lbNombreRazon.TabIndex = 11;
            lbNombreRazon.Text = "Nombre / Razón Social";
            // 
            // tbNombreRazon
            // 
            tbNombreRazon.Font = new Font("Segoe UI", 12F);
            tbNombreRazon.Location = new Point(30, 90);
            tbNombreRazon.MaxLength = 50;
            tbNombreRazon.Name = "tbNombreRazon";
            tbNombreRazon.Size = new Size(400, 29);
            tbNombreRazon.TabIndex = 0;
            // 
            // btRegistrarse
            // 
            btRegistrarse.AutoSize = true;
            btRegistrarse.BackColor = Color.FromArgb(0, 17, 61);
            btRegistrarse.FlatAppearance.BorderSize = 0;
            btRegistrarse.FlatStyle = FlatStyle.Flat;
            btRegistrarse.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btRegistrarse.ForeColor = SystemColors.ControlLightLight;
            btRegistrarse.Location = new Point(158, 135);
            btRegistrarse.Name = "btRegistrarse";
            btRegistrarse.RightToLeft = RightToLeft.No;
            btRegistrarse.Size = new Size(140, 30);
            btRegistrarse.TabIndex = 1;
            btRegistrarse.Text = "Registrarse";
            btRegistrarse.UseVisualStyleBackColor = false;
            btRegistrarse.Click += btRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 256);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 16;
            label3.Text = "¿No es tu NIT/CI?";
            // 
            // btVolver
            // 
            btVolver.BackColor = Color.FromArgb(0, 17, 61);
            btVolver.FlatAppearance.BorderSize = 0;
            btVolver.FlatStyle = FlatStyle.Flat;
            btVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btVolver.ForeColor = SystemColors.ControlLightLight;
            btVolver.Location = new Point(158, 286);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(140, 30);
            btVolver.TabIndex = 3;
            btVolver.Text = "Volver atras";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(lbWarninig);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 39);
            panel1.TabIndex = 21;
            // 
            // lbNitConfirm
            // 
            lbNitConfirm.AutoSize = true;
            lbNitConfirm.BackColor = SystemColors.Control;
            lbNitConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNitConfirm.ForeColor = SystemColors.ControlText;
            lbNitConfirm.Location = new Point(195, 179);
            lbNitConfirm.Name = "lbNitConfirm";
            lbNitConfirm.Size = new Size(63, 21);
            lbNitConfirm.TabIndex = 22;
            lbNitConfirm.Text = "NIT/CI:";
            // 
            // tbNit
            // 
            tbNit.Font = new Font("Cascadia Mono", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNit.Location = new Point(149, 203);
            tbNit.MaxLength = 12;
            tbNit.Name = "tbNit";
            tbNit.ReadOnly = true;
            tbNit.Size = new Size(159, 32);
            tbNit.TabIndex = 2;
            tbNit.Text = "000000000000";
            tbNit.TextAlign = HorizontalAlignment.Center;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 335);
            Controls.Add(tbNit);
            Controls.Add(lbNitConfirm);
            Controls.Add(btVolver);
            Controls.Add(label3);
            Controls.Add(btRegistrarse);
            Controls.Add(tbNombreRazon);
            Controls.Add(lbNombreRazon);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWarninig;
        private Label lbNombreRazon;
        private TextBox tbNombreRazon;
        private Button btRegistrarse;
        private Label label3;
        private Button btVolver;
        private Panel panel1;
        private Label lbNitConfirm;
        private TextBox tbNit;
    }
}