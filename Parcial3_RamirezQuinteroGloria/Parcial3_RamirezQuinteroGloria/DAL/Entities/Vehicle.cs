using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Parcial3_RamirezQuinteroGloria.DAL.Entities
{
    public class Vehicle : Entity
    {
    
        public Guid ServiceId { get; set; }


        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string? Owner { get; set; }

        [Required]
        public string? NumberPlate { get; set; }

        public Service Service { get; set; } //clave Foranea

        public ICollection<VehicleDatail> VehicleDatails { get; set; }


    }
}