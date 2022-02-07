using System.ComponentModel.DataAnnotations;
namespace WebApi.Models
{
    public class GoldDetailModel
    {
        [Required]
        public decimal GoldWeight { get; set; }
        [Required]
        public decimal GoldPrice { get; set; }
        public decimal? Discount { get; set; }
        //public string Name { get; set; }
        
    }
}
