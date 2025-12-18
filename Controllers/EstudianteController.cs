using SistemaNotasEscolares.Models;
using System.Collections.Generic;
using System.Linq;

public class EstudianteController
{
    public List<Estudiante> Listar()
    {
        using var db = new SistemaNotasDbContext();
        return db.Estudiantes.ToList();
    }

    public void Insertar(Estudiante e)
    {
        using var db = new SistemaNotasDbContext();
        db.Estudiantes.Add(e);
        db.SaveChanges();
    }

    public void Actualizar(Estudiante e)
    {
        using var db = new SistemaNotasDbContext();
        db.Estudiantes.Update(e);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        using var db = new SistemaNotasDbContext();
        var est = db.Estudiantes.Find(id);
        db.Estudiantes.Remove(est);
        db.SaveChanges();
    }
}
