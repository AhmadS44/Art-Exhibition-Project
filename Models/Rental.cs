using System.ComponentModel.DataAnnotations;

namespace Art_Exhibition_Project.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int ArtID { get; set; } // foreign key
        public int CustomerID { get; set; } // foreign key

        //price of the rental has to be between $100 - $500//
        [Required]
        [Range(10, 1000, ErrorMessage = "Please enter a vaild rental cost ($100 - $500)")]
        [Display(Name = "RentalCost")]
        public int RentalCost { get; set; }

        //this is the date of the rental//
        [Display(Name = "Rental Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentalDate { get; set; }

        //this is the date of the end of the rental//
        [Display(Name = "Rental Finish Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentalFinishDate { get; set; }
        public Art Art { get; set; }
        public Customer Customer { get; set; }

    }
}
