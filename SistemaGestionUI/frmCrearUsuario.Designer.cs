namespace SistemaGestionEntities
{
    partial class frmCrearUsuario
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
            label1 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnModificar = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 166);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 57;
            label1.Text = "Nombre Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 232);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 55;
            label6.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(52, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 29);
            txtNombre.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 101);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 50;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 49;
            label2.Text = "Nombre";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(121, 447);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(51, 324);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(312, 29);
            txtMail.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 296);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 59;
            label4.Text = "Mail";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(51, 190);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(312, 29);
            txtNombreUsuario.TabIndex = 61;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(51, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(312, 29);
            txtApellido.TabIndex = 63;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(51, 264);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(312, 29);
            txtContraseña.TabIndex = 64;
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(431, 509);
            Controls.Add(txtContraseña);
            Controls.Add(txtApellido);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Name = "frmCrearUsuario";
            Text = "frmCrearUsuario";
            Load += frmCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numStock;
        private Label label1;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtNombre;
        private NumericUpDown numPrecio;
        private NumericUpDown numCosto;
        private Label label3;
        private Label label2;
        private Button btnModificar;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtContraseña;
    }
}