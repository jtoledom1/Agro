using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class City
    {
        //JDTM 
        //Code first primero código clases luego la base de datos
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        
        public required string Name { get; set; }

    }
}
