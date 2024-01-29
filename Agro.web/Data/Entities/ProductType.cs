using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name="Tipo de producto")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Description")]
        public required string Description { get; set; }
        
    }
}
