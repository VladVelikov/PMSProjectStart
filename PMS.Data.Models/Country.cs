using System.ComponentModel.DataAnnotations;

namespace PMS.Data.Models
{
    public class Country
    {
        public Country() 
        {
            this.CountryId = Guid.NewGuid();
        }    

        public Guid CountryId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();    
    }
}