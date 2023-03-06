using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; } // Codigo del país

        // DATANOTATION
        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(200,ErrorMessage = "El campo {0} no puede tener más de {1} caracteres ")]
        public string Name { get; set; } = null!;
        public ICollection<State>? States { get; set; }

        [Display(Name = "Estados/Departamentos")]
        public int StatesNumber => States == null ? 0 : States.Count;

    }
}
