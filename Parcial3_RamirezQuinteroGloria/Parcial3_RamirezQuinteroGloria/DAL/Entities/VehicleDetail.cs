using System.ComponentModel.DataAnnotations;

namespace Parcial3_RamirezQuinteroGloria.DAL.Entities
{
    public class VehicleDatail : Entity
    {
        public int VehiculeId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public Vehicle Vehicle { get; set; } // relacion para la clave Foranea

    }

}
