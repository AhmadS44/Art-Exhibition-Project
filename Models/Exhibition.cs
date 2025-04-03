using System.ComponentModel.DataAnnotations;

namespace Art_Exhibition_Project.Models
{
    public class Exhibition
    {
        public int ExhibitionID { get; set; }

        //name of gallery and minimum of 3 characters and max of 20//
        [Required(ErrorMessage = "Gallery Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Gallery must be between 3 and 20 characters")]
        public string GalleryName { get; set; }

        //city of the location minimum of 3 characters and max of 20//
        [Required(ErrorMessage = "City is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "City must be between 3 and 20 characters")]
        public string City { get; set; }

        //zip of the location has to be in the range of 1000 - 9999//
        [Required]
        [Range(1000, 9999, ErrorMessage = "Please enter a vaild zip code (1000 - 9999)")]
        [Display(Name = "Zip")]
        public int Zip { get; set; }

        //country of the location minimum of 3 characters and max of 20//
        [Required(ErrorMessage = "Country is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Country must be between 3 and 20 characters")]
        public string Country { get; set; }

        //this is the date of the exhibition//
        [Display(Name = "Exhibition Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartingDate { get; set; }

        //this is the date of the end of exhibition//
        [Display(Name = "Exhibition End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FinishDate { get; set; }

    }
}
