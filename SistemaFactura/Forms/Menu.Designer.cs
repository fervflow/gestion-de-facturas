namespace SistemaFactura.Forms
{
    partial class Menu
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
            btnVerLista = new Button();
            btnRegistrarFact = new Button();
            pContenedor = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            pContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(btnVerLista);
            panel1.Controls.Add(btnRegistrarFact);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 54);
            panel1.TabIndex = 1;
            // 
            // btnVerLista
            // 
            btnVerLista.BackColor = Color.FromArgb(0, 17, 61);
            btnVerLista.FlatAppearance.BorderSize = 0;
            btnVerLista.FlatStyle = FlatStyle.Flat;
            btnVerLista.Font = new Font("Segoe UI", 11F);
            btnVerLista.ForeColor = SystemColors.ControlLightLight;
            btnVerLista.Location = new Point(409, 12);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Size = new Size(288, 33);
            btnVerLista.TabIndex = 15;
            btnVerLista.Text = "VER LISTA DE FACTURAS";
            btnVerLista.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarFact
            // 
            btnRegistrarFact.BackColor = Color.FromArgb(0, 17, 61);
            btnRegistrarFact.FlatAppearance.BorderSize = 0;
            btnRegistrarFact.FlatStyle = FlatStyle.Flat;
            btnRegistrarFact.Font = new Font("Segoe UI", 11F);
            btnRegistrarFact.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarFact.Location = new Point(67, 12);
            btnRegistrarFact.Name = "btnRegistrarFact";
            btnRegistrarFact.Size = new Size(273, 33);
            btnRegistrarFact.TabIndex = 15;
            btnRegistrarFact.Text = "REGISTRAR FACTURAS";
            btnRegistrarFact.UseVisualStyleBackColor = false;
            btnRegistrarFact.Click += btnRegistrarFact_Click;
            // 
            // pContenedor
            // 
            pContenedor.AutoScroll = true;
            pContenedor.Controls.Add(label2);
            pContenedor.Dock = DockStyle.Fill;
            pContenedor.Location = new Point(0, 54);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(771, 508);
            pContenedor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(684, 484);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 9;
            label2.Text = "JEELM©2024";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 562);
            Controls.Add(pContenedor);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVerLista;
        private Button btnRegistrarFact;
        private Panel pContenedor;
        private Label label2;
    }
}