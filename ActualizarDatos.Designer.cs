namespace ProyectoCatedra
{
    partial class ActualizarDatos
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
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaIncorporación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(387, 341);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 26);
            this.buttonInicio.TabIndex = 28;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(99, 311);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(111, 52);
            this.buttonActualizar.TabIndex = 27;
            this.buttonActualizar.Text = "Seleccionar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.Location = new System.Drawing.Point(227, 311);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(111, 52);
            this.buttonSeleccionar.TabIndex = 26;
            this.buttonSeleccionar.Text = "Actualizar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnPuesto,
            this.ColumnSalario,
            this.ColumnFechaIncorporación});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(9, 42);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(453, 245);
            this.dataGridViewEmpleados.TabIndex = 25;
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
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(26, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(421, 31);
            this.labelTitulo.TabIndex = 24;
            this.labelTitulo.Text = "Actualizar Datos de Empleados";
            // 
            // ActualizarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 375);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.labelTitulo);
            this.Name = "ActualizarDatos";
            this.Text = "ActualizarDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaIncorporación;
        private System.Windows.Forms.Label labelTitulo;
    }
}