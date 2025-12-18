using SistemaNotasEscolares.Models;

namespace SistemaNotasEscolares.Controllers
{
    public class ReportesController
    {
        public List<object> NotasPorMateria(int idMateria)
        {
            using var db = new SistemaNotasDbContext();

            return db.Notas
                .Where(n => n.IdMateria == idMateria)
                .Select(n => new
                {
                    Estudiante = n.IdEstudianteNavigation.Nombre + " " + n.IdEstudianteNavigation.Apellido,
                    Materia = n.IdMateriaNavigation.NombreMateria,
                    Nota = n.Calificacion
                })
                .ToList<object>();
        }
    }
}
