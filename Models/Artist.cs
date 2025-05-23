﻿using System.ComponentModel.DataAnnotations;

namespace Art_Exhibition_Project.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        //First name has to have uppercase and limited to 25 characters//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //the minimum length of the address is 5 and max is 100//
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }

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

        //phone number needs to be a number and limited to 10 characters//
        [Required]
        [Range(0210000000, 0219999999, ErrorMessage = "Please enter a vaild phone number (021-0000000)")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
        public ICollection<Art> Art { get; set; }
    }
}

