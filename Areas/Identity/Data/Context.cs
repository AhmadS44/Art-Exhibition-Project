using Art_Exhibition_Project.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Art_Exhibition_Project.Models;

namespace Art_Exhibition_Project;

public class Context : IdentityDbContext<Art_Exhibition_ProjectUser>
{
    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<Art_Exhibition_Project.Models.Art> Art { get; set; } = default!;

public DbSet<Art_Exhibition_Project.Models.Artist> Artist { get; set; } = default!;

public DbSet<Art_Exhibition_Project.Models.Customer> Customer { get; set; } = default!;

public DbSet<Art_Exhibition_Project.Models.Exhibition> Exhibition { get; set; } = default!;

public DbSet<Art_Exhibition_Project.Models.PurchaseOrder> PurchaseOrder { get; set; } = default!;

public DbSet<Art_Exhibition_Project.Models.Rental> Rental { get; set; } = default!;
}
