namespace SistemaGestionEntities
{
    partial class FrmProducto
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Descripciones, Costo, PrecioVenta, Stock, btnEditar, btnEliminar });
            dataGridView1.Location = new System.Drawing.Point(29, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(740, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(646, 26);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(75, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += this.btnCrear_Click;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnCrear);
            this.Controls.Add(dataGridView1);
            this.Name = "FrmProducto";
            this.Text = "Productos";
            this.Load += this.Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
    }
}