using System.ComponentModel.DataAnnotations;

namespace AllTrailsAdmin.Models
{
    public class Trail
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [StringLength(2500)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Length (km)")]
        [Range(0.1, 280000)]
        [Required]
        public double Length { get; set; } // 7.9km

        [Display(Name = "Elevation Gain (m)")]
        [Range(-441, 30000)]
        [Required]
        public int ElevationGain { get; set; } // 200m

        [Required]
        public string Location { get; set; } = string.Empty; // address, city, province...display Google map later
        
        //Url to image stored in Azure Storage
        public string ImageUrl { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        [Display(Name = "Created")]
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now; // default to current timestamp
    }
}
