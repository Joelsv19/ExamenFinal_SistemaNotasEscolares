using SistemaNotasEscolares.Models;
using SistemaNotasEscolares.Views;
namespace _02_CRUD.Vistas.Dashboad
{

    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void frm_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNotas = new frmNotas();
          
            frmNotas.Show(); 
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEstudiantes = new frmEstudiantes();
          
            frmEstudiantes.Show();

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMaterias = new frmMaterias();
       
            frmMaterias.Show();

        }
    }
}
