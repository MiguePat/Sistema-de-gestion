namespace SistemaGestionEntities
{
    partial class Menu_principal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(75, 28);
            button1.Name = "button1";
            button1.Size = new Size(262, 62);
            button1.TabIndex = 0;
            button1.Text = "Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(76, 116);
            button2.Name = "button2";
            button2.Size = new Size(259, 59);
            button2.TabIndex = 1;
            button2.Text = "Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(78, 200);
            button3.Name = "button3";
            button3.Size = new Size(253, 62);
            button3.TabIndex = 2;
            button3.Text = "Ventas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(263, 433);
            button4.Name = "button4";
            button4.Size = new Size(68, 47);
            button4.TabIndex = 3;
            button4.Text = "Cerrar sesion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(75, 433);
            button5.Name = "button5";
            button5.Size = new Size(182, 47);
            button5.TabIndex = 4;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Menu_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(417, 516);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu_principal";
            Text = "Menu_principal";
            Load += Menu_principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}