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
    public partial class AgregarEmpleado : Form
    {
        private List<string> listaEmpleados = new List<string>();
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string puesto = txtPuesto.Text;
            string salario = txtSalario.Text;

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(puesto) && !string.IsNullOrWhiteSpace(salario))
            {
                listaEmpleados.Add($"Nombre: {nombre}, Puesto: {puesto}, Salario: {salario}");

                MessageBox.Show("Empleado agregado: " + nombre);

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPuesto.Text = "";
            txtSalario.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados correctamente.");
            this.Close();
        }
    }
}
