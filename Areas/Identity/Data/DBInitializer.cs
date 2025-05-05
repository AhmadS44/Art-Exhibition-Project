using Art_Exhibition_Project.Models;

namespace Art_Exhibition_Project.Areas.Identity.Data
{
    public class DBInitializer
    {
        internal static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "MOUTEZ", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Man", Address = "25Road", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0212826062, Email = "connorm1@gmail.com" },
            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();


            var artists = new Artist[]
             {
                 new Artist { FirstName = "William", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Yamaha MT-09", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Harley-Davidson Fat Boy", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Kawasaki Z900", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Suzuki Hayabusa", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Ducati Monster", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "BMW R1250GS", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Triumph Bonneville T120", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "KTM 390 Duke", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
                 new Artist { FirstName = "Aprilia Tuono V4", LastName = "William", Address = "William", City = "25Road", Zip = 1979, Country = "New Zealand", PhoneNumber = 0216421822 },
             };
            foreach (Artist a in artists)
            {
                context.Artist.Add(a);
            }
            context.SaveChanges();

            var arts = new Art[]
            {
                new Art { ArtistID = 1, Title = "Daniel", Price = 20, Description = "Danielpatel@gmail.com" },
                new Art { ArtistID = 2,  Title = "Emily", Price = 10, Description = "emilyj@gmail.com" },
                new Art { ArtistID = 3,  Title = "Sophia", Price = -10, Description = "Swilliams22@gmail.com" },
                new Art { ArtistID = 4,  Title = "Ethan", Price = 20, Description = "ethanB@gmail.com" },
                new Art { ArtistID = 5,  Title = "Olivia", Price = 20, Description = "oliviaDa88@gmail.com" },
                new Art { ArtistID = 6,  Title = "Jacob", Price = 20, Description = "jacobMartinez22@gmail.com" },
                new Art { ArtistID = 7, Title = "Ava", Price = 20, Description = "avag9@gmail.com" },
                new Art { ArtistID = 8,  Title = "William", Price = 20, Description = "williamj21@gmail.com" },
                new Art { ArtistID = 9,  Title = "Isabella", Price = 20, Description = "irodriguez2@gmail.com" },
                new Art { ArtistID = 10,  Title = "Liam", Price = 20, Description = "liamanderson0@gmail.com" },
            };
            foreach (Art a in arts)
            {
                context.Art.Add(a);
            }
            context.SaveChanges();
            ;



            var purchaseorders = new PurchaseOrder[]
          {
              new PurchaseOrder { ArtID = 1, CustomerID = 1, OrderCost = 100, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 2, CustomerID = 2, OrderCost = 2, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 3, CustomerID = 3, OrderCost = 3, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 4, CustomerID = 4, OrderCost = 4, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 5, CustomerID = 5, OrderCost = 5, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 6, CustomerID = 6, OrderCost = 70, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 7, CustomerID = 7, OrderCost = 7, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 8, CustomerID = 8, OrderCost = 8, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 9, CustomerID = 9, OrderCost = 9, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
              new PurchaseOrder { ArtID = 10, CustomerID = 10, OrderCost = 10, OrderDate = DateTime.Parse("2004-06-11"), StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
          };
            foreach (PurchaseOrder p in purchaseorders)
            {
                context.PurchaseOrder.Add(p);
            }
            context.SaveChanges();



            var rentals = new Rental[]
            {
                new Rental { ArtID = 1, CustomerID = 1, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 2, CustomerID = 2, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 3, CustomerID = 3, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 4, CustomerID = 4, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 5, CustomerID = 5, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 6, CustomerID = 6, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 7, CustomerID = 7, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 8, CustomerID = 8, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 9, CustomerID = 9, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
                new Rental { ArtID = 10, CustomerID = 10, RentalCost = 07, RentalDate = DateTime.Parse("2007-06-11"), RentalFinishDate = DateTime.Parse("2010-06-11") },
            };
            foreach (Rental r in rentals)
            {
                context.Rental.Add(r);
            }
            context.SaveChanges();

             var exhibitions = new Exhibition[]
            {
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 1021, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 0624, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Christchurch", Zip = 8011, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 1024, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 1011, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 0622, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Wellington", Zip = 6012, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Wellington", Zip = 6011, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 1010, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
                new Exhibition { GalleryName = "AucklandGallery", City = "Auckland", Zip = 1052, Country = "New Zealand", StartingDate = DateTime.Parse("2002-06-11"), FinishDate = DateTime.Parse("2002-06-12") },
            };
            foreach (Exhibition e in exhibitions)
            {
                context.Exhibition.Add(e);
            }
            context.SaveChanges();

        }
    }
}

        
    
