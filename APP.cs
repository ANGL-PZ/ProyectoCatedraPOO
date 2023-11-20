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
    public partial class APP : Form
    {
        public APP()
        {
            InitializeComponent();
        }

        private void buttonAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarForm = new AgregarEmpleado();
            agregarForm.Show();

        }

        private void buttonEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado agregarFrom = new EliminarEmpleado();
            agregarFrom.Show();
        }

        private void buttonListaEmpleados_Click(object sender, EventArgs e)
        {
            ListaEmpleados agregarForm = new ListaEmpleados();
            agregarForm.Show();
        }

        private void buttonRecolocacionPersonal_Click(object sender, EventArgs e)
        {
            RecolocacionPersonal agregarForm = new RecolocacionPersonal();
            agregarForm.Show();

        }

        private void buttonVacacionesyAusencias_Click(object sender, EventArgs e)
        {
            ControlVacacionesAusencias agregarForm = new ControlVacacionesAusencias();
            agregarForm.Show();
        }

        private void buttonActualizarDatos_Click(object sender, EventArgs e)
        {
            ActualizarDatos agregarForm = new ActualizarDatos();
            agregarForm.Show(); 
        }

        private void buttonCrearInforme_Click(object sender, EventArgs e)
        {
            CrearInforme agregarForm = new CrearInforme();
            agregarForm.Show();
        }
    }
}
