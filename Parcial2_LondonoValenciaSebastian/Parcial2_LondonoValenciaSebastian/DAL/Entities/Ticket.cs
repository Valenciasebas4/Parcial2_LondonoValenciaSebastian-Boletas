using System.ComponentModel.DataAnnotations;

namespace Parcial2_LondonoValenciaSebastian.DAL.Entities
{
    public class Ticket
    {
        #region Properties
        [Key] //PROPERTY KEY
        public virtual Guid Id { get; set; }

        [Display(Name = "Fecha de Uso")]
        public virtual DateTime? UseDate { get; set; }

        [Display(Name = "Se uso?")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string IsUsed { get; set; }

        [Display(Name = "Porteria de Entrada")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        public string? EntranceGate { get; set; }
        #endregion
    }
}
