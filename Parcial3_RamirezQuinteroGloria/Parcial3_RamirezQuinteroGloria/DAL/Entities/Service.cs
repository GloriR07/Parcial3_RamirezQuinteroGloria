namespace Parcial3_RamirezQuinteroGloria.DAL.Entities
{
    public class Service : Entity
    {

        public string? Name { get; set; }

        public float Price { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

        //public int Servicenumber => Vehicles.Count;
    }
}
