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
    public partial class frmMaterias : Form
    {
        MateriaController ctrl = new MateriaController();
        int idSeleccionado = 0;
        public frmMaterias()
        {
            InitializeComponent();
        }
        private void frmMaterias_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = ctrl.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ctrl.Insertar(new Materia { NombreMateria = txtMateria.Text });
            txtMateria.Clear();
            dgvMaterias.DataSource = ctrl.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ctrl.Actualizar(new Materia
            {
                IdMateria = idSeleccionado,
                NombreMateria = txtMateria.Text
            });

            txtMateria.Clear();
            dgvMaterias.DataSource = ctrl.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ctrl.Eliminar(idSeleccionado);
            dgvMaterias.DataSource = ctrl.Listar();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (int)dgvMaterias.CurrentRow.Cells["IdMateria"].Value;
            txtMateria.Text = dgvMaterias.CurrentRow.Cells["NombreMateria"].Value.ToString();
        }
    
    }
}
