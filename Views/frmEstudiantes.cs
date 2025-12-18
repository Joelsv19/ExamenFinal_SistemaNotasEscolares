using SistemaNotasEscolares.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotasEscolares.Views
{
    public partial class frmEstudiantes : Form
    {

        EstudianteController ctrl = new EstudianteController();
        int idSeleccionado = 0;

        public frmEstudiantes()
        {
            InitializeComponent();
        }
        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dgvEstudiantes.DataSource = ctrl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante e1 = new Estudiante
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text
            };

            ctrl.Insertar(e1);
            Limpiar();
            Cargar();
        }




        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Estudiante e1 = new Estudiante
            {
                IdEstudiante = idSeleccionado,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text
            };

            ctrl.Actualizar(e1);
            Limpiar();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ctrl.Eliminar(idSeleccionado);
            Limpiar();
            Cargar();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (int)dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value;
            txtNombre.Text = dgvEstudiantes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvEstudiantes.CurrentRow.Cells["Apellido"].Value.ToString();
        }
    }
}
