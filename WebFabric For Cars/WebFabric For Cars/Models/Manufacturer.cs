using System.ComponentModel.DataAnnotations;

namespace WebFabric_For_Cars.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameManufactur { get; set; }
        [Required]
        public DateTime EstablishedOn { get; set; }
        //Navigation Property
        public ICollection<Model> Models { get; set; }=new List<Model>();
    }
}
