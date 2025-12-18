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
    public partial class frmNotas : Form
    {
        NotaController notaCtrl = new NotaController();
        public frmNotas()
        {
            InitializeComponent();
            this.Load += frmNotas_Load;
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            using var db = new SistemaNotasDbContext();

            cbEstudiantes.DataSource = db.Estudiantes
                .Select(e => new
                {
                    e.IdEstudiante,
                    NombreCompleto = e.Nombre + " " + e.Apellido
                }).ToList();

            cbEstudiantes.DisplayMember = "NombreCompleto";
            cbEstudiantes.ValueMember = "IdEstudiante";

            cbMaterias.DataSource = db.Materias.ToList();
            cbMaterias.DisplayMember = "NombreMateria";
            cbMaterias.ValueMember = "IdMateria";

            dgvNotas.DataSource = notaCtrl.Listar();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nota n = new Nota
            {
                IdEstudiante = (int)cbEstudiantes.SelectedValue,
                IdMateria = (int)cbMaterias.SelectedValue,
                Calificacion = decimal.Parse(txtNota.Text)
            };

            notaCtrl.Insertar(n);
            txtNota.Clear();
            dgvNotas.DataSource = notaCtrl.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int id = (int)dgvNotas.CurrentRow.Cells["IdNota"].Value;
            notaCtrl.Eliminar(id);
            dgvNotas.DataSource = notaCtrl.Listar();
        }
    }
}
