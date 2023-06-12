using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string FirstName { get; set; }

    [PersonalData]
    public string LastName { get; set; }
}

