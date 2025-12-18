using Microsoft.EntityFrameworkCore;
using SistemaNotasEscolares.Models;
using System.Linq;

public class NotaController
{
    public object Listar()
    {
        using var db = new SistemaNotasDbContext();
        return db.Notas
            .Include(n => n.IdEstudianteNavigation)
            .Include(n => n.IdMateriaNavigation)
            .Select(n => new
            {
                n.IdNota,
                Estudiante = n.IdEstudianteNavigation.Nombre + " " + n.IdEstudianteNavigation.Apellido,
                Materia = n.IdMateriaNavigation.NombreMateria,
                Nota = n.Calificacion
            }).ToList();
    }

    public void Insertar(Nota n)
    {
        using var db = new SistemaNotasDbContext();
        db.Notas.Add(n);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        using var db = new SistemaNotasDbContext();
        var nota = db.Notas.Find(id);
        db.Notas.Remove(nota);
        db.SaveChanges();
    }
}
