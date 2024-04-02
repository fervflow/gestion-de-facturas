namespace SistemaFactura
{
    partial class FormLogin
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtNit = new TextBox();
            btnAcceder = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtNit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 47);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(232, 14);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "NIT/CI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(35, 14);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(103, 11);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtNit
            // 
            txtNit.Location = new Point(292, 11);
            txtNit.MaxLength = 15;
            txtNit.Name = "txtNit";
            txtNit.PasswordChar = '*';
            txtNit.Size = new Size(121, 23);
            txtNit.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Red;
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ControlLightLight;
            btnAcceder.Location = new Point(289, 117);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(110, 30);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 161);
            Controls.Add(btnAcceder);
            Controls.Add(panel1);
            MaximumSize = new Size(450, 200);
            MinimumSize = new Size(450, 200);
            Name = "FormLogin";
            Text = "Ingresar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtNit;
        private Button btnAcceder;
    }
}
