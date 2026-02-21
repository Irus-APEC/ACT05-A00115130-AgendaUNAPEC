using System.ComponentModel.DataAnnotations;

namespace AgendaUNAPEC.Models
{
    public class Contacto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(120)]
        public string Email { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefono { get; set; }
    }
}