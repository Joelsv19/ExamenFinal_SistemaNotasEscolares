using SistemaNotasEscolares.Models;
using System.Collections.Generic;
using System.Linq;

public class MateriaController
{
    public List<Materia> Listar()
    {
        using var db = new SistemaNotasDbContext();
        return db.Materias.ToList();
    }

    public void Insertar(Materia m)
    {
        using var db = new SistemaNotasDbContext();
        db.Materias.Add(m);
        db.SaveChanges();
    }

    public void Actualizar(Materia m)
    {
        using var db = new SistemaNotasDbContext();
        db.Materias.Update(m);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        using var db = new SistemaNotasDbContext();
        var mat = db.Materias.Find(id);
        db.Materias.Remove(mat);
        db.SaveChanges();
    }
}
