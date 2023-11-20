using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    public partial class EliminarEmpleado : Form
    {
        private List<Empleado> listaEmpleados = new List<Empleado>();
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listaEmpleados.Count > 0)
            {
                listaEmpleados.RemoveAt(listaEmpleados.Count - 1); 
                MessageBox.Show("Empleado eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No hay empleados para eliminar.");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados correctamente");
            this.Close();

        }
    }
}
