using SistemaNotasEscolares.Controllers;
using SistemaNotasEscolares.Models;

namespace SistemaNotasEscolares.Views
{
    public partial class frmReporteNotas : Form
    {
        ReportesController rptCtrl = new ReportesController();
        public frmReporteNotas()
        {
            InitializeComponent();
            this.Load += frmReporteNotas_Load;
        }
        private void frmReporteNotas_Load(object sender, EventArgs e)
        {
            using var db = new SistemaNotasDbContext();

            cbMaterias.DataSource = db.Materias.ToList();
            cbMaterias.DisplayMember = "NombreMateria";
            cbMaterias.ValueMember = "IdMateria";
            cbMaterias.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia");
                return;
            }

            int idMateria = (int)cbMaterias.SelectedValue;
            dgvReporte.DataSource = rptCtrl.NotasPorMateria(idMateria);
        }
    }
}
