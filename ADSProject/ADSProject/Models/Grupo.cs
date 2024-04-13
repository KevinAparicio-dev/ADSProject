using ADSProject.Validaciones;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdGrupo))]
    public class Grupo
    {
        public int IdGrupo { get; set; }
        [ValidacionesPersonalizadas(ErrorMessage = "Este es un campo requerido")]
        public int IdCarrera { get; set; }
        [ValidacionesPersonalizadas(ErrorMessage = "Este es un campo requerido")]
        public int IdMateria { get; set; }
        [ValidacionesPersonalizadas(ErrorMessage = "Este es un campo requerido")]
        public int IdProfesor { get; set; }
        [ValidacionesPersonalizadas(ErrorMessage = "Este es un campo requerido")]
        public int Ciclo { get; set; }
        [ValidacionesPersonalizadas(ErrorMessage = "Este es un campo requerido")]
        public int Anio { get; set; }
    }
}
