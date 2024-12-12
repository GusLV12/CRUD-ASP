using System.ComponentModel.DataAnnotations;

namespace CRUDASP.Models
{
    public class ContactoModel
    {
        public int idContacto {  get; set; }
        [Required(ErrorMessage = "Es Obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Es Obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Es Obligatorio")]
        public string? Correo { get; set; }

    }
}
