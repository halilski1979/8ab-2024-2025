using System.ComponentModel.DataAnnotations;

namespace WebFabric_For_Cars.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ModelId { get; set; }
        [Required]
        //Navigation property
        public int ManufacturerID { get; set; }
      
        public Manufacturer? Manufacturer { get; set; }
    }
}
