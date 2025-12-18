using System;
using System.Collections.Generic;

namespace SistemaNotasEscolares.Models;

public partial class Nota
{
    public int IdNota { get; set; }

    public int IdEstudiante { get; set; }

    public int IdMateria { get; set; }

    public decimal Calificacion { get; set; }

    public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;

    public virtual Materia IdMateriaNavigation { get; set; } = null!;
}
