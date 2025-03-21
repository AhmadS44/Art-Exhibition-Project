using Microsoft.AspNetCore.Identity;

namespace Art_Exhibition_Project.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}

    
  