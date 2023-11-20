namespace ProyectoCatedra
{
    partial class ListaEmpleados
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaIncorporación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(100, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(269, 31);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Lista de Empleados";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnPuesto,
            this.ColumnSalario,
            this.ColumnFechaIncorporación});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(11, 42);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(725, 353);
            this.dataGridViewEmpleados.TabIndex = 7;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnPuesto
            // 
            this.ColumnPuesto.HeaderText = "Puesto";
            this.ColumnPuesto.Name = "ColumnPuesto";
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salario";
            this.ColumnSalario.Name = "ColumnSalario";
            // 
            // ColumnFechaIncorporación
            // 
            this.ColumnFechaIncorporación.FillWeight = 110F;
            this.ColumnFechaIncorporación.HeaderText = "Fecha de Incorporación";
            this.ColumnFechaIncorporación.Name = "ColumnFechaIncorporación";
            // 
            // buttonInicio
            // 
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.Location = new System.Drawing.Point(665, 400);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(71, 26);
            this.buttonInicio.TabIndex = 17;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ListaEmpleados";
            this.Text = "ListaEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaIncorporación;
        private System.Windows.Forms.Button buttonInicio;
    }
}