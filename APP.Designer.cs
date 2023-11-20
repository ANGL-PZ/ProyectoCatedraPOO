namespace ProyectoCatedra
{
    partial class APP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregarEmpleado = new System.Windows.Forms.Button();
            this.buttonEliminarEmpleado = new System.Windows.Forms.Button();
            this.buttonRecolocacionPersonal = new System.Windows.Forms.Button();
            this.buttonActualizarDatos = new System.Windows.Forms.Button();
            this.buttonCrearInforme = new System.Windows.Forms.Button();
            this.buttonVacacionesyAusencias = new System.Windows.Forms.Button();
            this.buttonListaEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "APLICACIÓN RRHH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(829, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione a continuación la acción que desea realizar:";
            // 
            // buttonAgregarEmpleado
            // 
            this.buttonAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarEmpleado.Location = new System.Drawing.Point(205, 156);
            this.buttonAgregarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgregarEmpleado.Name = "buttonAgregarEmpleado";
            this.buttonAgregarEmpleado.Size = new System.Drawing.Size(244, 53);
            this.buttonAgregarEmpleado.TabIndex = 2;
            this.buttonAgregarEmpleado.Text = "Agregar Empleado";
            this.buttonAgregarEmpleado.UseVisualStyleBackColor = true;
            this.buttonAgregarEmpleado.Click += new System.EventHandler(this.buttonAgregarEmpleado_Click);
            // 
            // buttonEliminarEmpleado
            // 
            this.buttonEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarEmpleado.Location = new System.Drawing.Point(561, 156);
            this.buttonEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminarEmpleado.Name = "buttonEliminarEmpleado";
            this.buttonEliminarEmpleado.Size = new System.Drawing.Size(244, 53);
            this.buttonEliminarEmpleado.TabIndex = 3;
            this.buttonEliminarEmpleado.Text = "Eliminar Empleado";
            this.buttonEliminarEmpleado.UseVisualStyleBackColor = true;
            this.buttonEliminarEmpleado.Click += new System.EventHandler(this.buttonEliminarEmpleado_Click);
            // 
            // buttonRecolocacionPersonal
            // 
            this.buttonRecolocacionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecolocacionPersonal.Location = new System.Drawing.Point(204, 346);
            this.buttonRecolocacionPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRecolocacionPersonal.Name = "buttonRecolocacionPersonal";
            this.buttonRecolocacionPersonal.Size = new System.Drawing.Size(244, 62);
            this.buttonRecolocacionPersonal.TabIndex = 4;
            this.buttonRecolocacionPersonal.Text = "Recolocación de Personal";
            this.buttonRecolocacionPersonal.UseVisualStyleBackColor = true;
            this.buttonRecolocacionPersonal.Click += new System.EventHandler(this.buttonRecolocacionPersonal_Click);
            // 
            // buttonActualizarDatos
            // 
            this.buttonActualizarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarDatos.Location = new System.Drawing.Point(560, 454);
            this.buttonActualizarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonActualizarDatos.Name = "buttonActualizarDatos";
            this.buttonActualizarDatos.Size = new System.Drawing.Size(244, 53);
            this.buttonActualizarDatos.TabIndex = 5;
            this.buttonActualizarDatos.Text = "Actualizar Datos";
            this.buttonActualizarDatos.UseVisualStyleBackColor = true;
            this.buttonActualizarDatos.Click += new System.EventHandler(this.buttonActualizarDatos_Click);
            // 
            // buttonCrearInforme
            // 
            this.buttonCrearInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearInforme.Location = new System.Drawing.Point(204, 454);
            this.buttonCrearInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCrearInforme.Name = "buttonCrearInforme";
            this.buttonCrearInforme.Size = new System.Drawing.Size(244, 53);
            this.buttonCrearInforme.TabIndex = 6;
            this.buttonCrearInforme.Text = "Crear Informe";
            this.buttonCrearInforme.UseVisualStyleBackColor = true;
            this.buttonCrearInforme.Click += new System.EventHandler(this.buttonCrearInforme_Click);
            // 
            // buttonVacacionesyAusencias
            // 
            this.buttonVacacionesyAusencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVacacionesyAusencias.Location = new System.Drawing.Point(560, 346);
            this.buttonVacacionesyAusencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVacacionesyAusencias.Name = "buttonVacacionesyAusencias";
            this.buttonVacacionesyAusencias.Size = new System.Drawing.Size(244, 62);
            this.buttonVacacionesyAusencias.TabIndex = 7;
            this.buttonVacacionesyAusencias.Text = "Control de Vacaciones y Ausencias";
            this.buttonVacacionesyAusencias.UseVisualStyleBackColor = true;
            this.buttonVacacionesyAusencias.Click += new System.EventHandler(this.buttonVacacionesyAusencias_Click);
            // 
            // buttonListaEmpleados
            // 
            this.buttonListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaEmpleados.Location = new System.Drawing.Point(383, 255);
            this.buttonListaEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListaEmpleados.Name = "buttonListaEmpleados";
            this.buttonListaEmpleados.Size = new System.Drawing.Size(239, 53);
            this.buttonListaEmpleados.TabIndex = 8;
            this.buttonListaEmpleados.Text = "Lista de Empleados";
            this.buttonListaEmpleados.UseVisualStyleBackColor = true;
            this.buttonListaEmpleados.Click += new System.EventHandler(this.buttonListaEmpleados_Click);
            // 
            // APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1043, 554);
            this.Controls.Add(this.buttonListaEmpleados);
            this.Controls.Add(this.buttonVacacionesyAusencias);
            this.Controls.Add(this.buttonCrearInforme);
            this.Controls.Add(this.buttonActualizarDatos);
            this.Controls.Add(this.buttonRecolocacionPersonal);
            this.Controls.Add(this.buttonEliminarEmpleado);
            this.Controls.Add(this.buttonAgregarEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "APP";
            this.Text = "APP RRHH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregarEmpleado;
        private System.Windows.Forms.Button buttonEliminarEmpleado;
        private System.Windows.Forms.Button buttonRecolocacionPersonal;
        private System.Windows.Forms.Button buttonActualizarDatos;
        private System.Windows.Forms.Button buttonCrearInforme;
        private System.Windows.Forms.Button buttonVacacionesyAusencias;
        private System.Windows.Forms.Button buttonListaEmpleados;
    }
}

