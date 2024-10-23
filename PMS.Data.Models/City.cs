using System.ComponentModel.DataAnnotations;

namespace PMS.Data.Models
{
    public class City
    {
        public City() 
        {
            this.CityId = Guid.NewGuid();   
        }

        public Guid CityId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();    
    }
}