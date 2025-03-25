using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Art_Exhibition_Project.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Art_Exhibition_ProjectUser class
public class Art_Exhibition_ProjectUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }
}

