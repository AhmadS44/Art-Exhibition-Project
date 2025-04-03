using System.ComponentModel.DataAnnotations;

namespace Art_Exhibition_Project.Models
{
    public class Art
    {
        public int ArtId { get; set; }
        public int ArtistID { get; set; } // foreign key

        //Title of the art piece//
        [Required(ErrorMessage = "Title is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 20 characters")]
        public string Title { get; set; }

        //price of the art piece has to be between $5 - $5000//
        [Required]
        [Range(10, 1000, ErrorMessage = "Please enter a vaild rental cost ($5 - $5000)")]
        [Display(Name = "ArtPrice")]
        public int Price { get; set; }

        //discreption of the art piece//
        [Required(ErrorMessage = "Description is required")]
        [StringLength(150, MinimumLength = 35, ErrorMessage = "Description must be between 35 and 150 characters")]
        public string Description { get; set; }
        
        public Artist Artist { get; set; }
        public ICollection<Rental> Rental { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }

    }
}
