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
                new Customer { FirstName = "Daniel", LastName = "Jacobs", Address = "25 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0212826065, Email = "daniel@gmail.com" },
                new Customer { FirstName = "Jacob", LastName = "Brown", Address = "22 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0212182867, Email = "jacob@gmail.com" },
                new Customer { FirstName = "Bob", LastName = "Johnson", Address = "77 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0212881262, Email = "bob@gmail.com" },
                new Customer { FirstName = "Moutez", LastName = "Williams", Address = "19 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0211826063, Email = "moutez@gmail.com" },
                new Customer { FirstName = "Yousif", LastName = "Nickelson", Address = "29 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0212826069, Email = "yousif@gmail.com" },
                new Customer { FirstName = "Prasad", LastName = "Mister", Address = "19 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0212826009, Email = "prasad@gmail.com" },
                new Customer { FirstName = "Terry", LastName = "Jones", Address = "4 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0212826271, Email = "terry@gmail.com" },
                new Customer { FirstName = "Darius", LastName = "Hodge", Address = "7 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0212820281, Email = "darius@gmail.com" },
                new Customer { FirstName = "John", LastName = "Clerk", Address = "12 Birch Road", City = "Wellington", Zip = 1800, Country = "New Zealand", PhoneNumber = 0211827362, Email = "john@gmail.com" },
                new Customer { FirstName = "Pat", LastName = "Zimb", Address = "2 Willow Road", City = "Hamilton", Zip = 1200, Country = "New Zealand", PhoneNumber = 0212738562, Email = "pat@gmail.com" },
            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();


            var artists = new Artist[]
             {
                 new Artist { FirstName = "Lickhit", LastName = "Pate;", Address = "16 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0211827164 },
                 new Artist { FirstName = "Albert", LastName = "Einstein", Address = "92 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0216427162 },
                 new Artist { FirstName = "Mike", LastName = "Tyson", Address = "3 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0219182736 },
                 new Artist { FirstName = "Silver", LastName = "Johnothan", Address = "5 Willow Road Road", City = "Hamilton", Zip = 1200, Country = "New Zealand", PhoneNumber = 0219173728 },
                 new Artist { FirstName = "Suzuki", LastName = "Haya", Address = "78 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0216428172 },
                 new Artist { FirstName = "Jackson", LastName = "Michealson", Address = "54 Willow Road", City = "Hamilton", Zip = 1200, Country = "New Zealand", PhoneNumber = 0216428172 },
                 new Artist { FirstName = "Jhin", LastName = "Kazama", Address = "22 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0218172622 },
                 new Artist { FirstName = "Leonardo", LastName = "Caprio", Address = "17 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0216493842 },
                 new Artist { FirstName = "Lisa", LastName = "Gurenge", Address = "45 New Street", City = "Chirstchurch", Zip = 4200, Country = "New Zealand", PhoneNumber = 0216482732 },
                 new Artist { FirstName = "Micheal", LastName = "Phelps", Address = "88 Country Road", City = "Auckland", Zip = 1600, Country = "New Zealand", PhoneNumber = 0216182736 },
             };
            foreach (Artist a in artists)
            {
                context.Artist.Add(a);
            }
            context.SaveChanges();

            var arts = new Art[]
            {
               new Art { ArtistID = 1, Title = "Daniel", Price = 20, Description = "A portrait of the mountains" },
                new Art { ArtistID = 2,  Title = "Emily", Price = 10, Description = "The sun over the river" },
                new Art { ArtistID = 3,  Title = "Sophia", Price = 10, Description = "The moonlight shining down" },
                new Art { ArtistID = 4,  Title = "Ethan", Price = 20, Description = "Trees of our nature" },
                new Art { ArtistID = 5,  Title = "Olivia", Price = 20, Description = "Shows society as it is" },
                new Art { ArtistID = 6,  Title = "Jacob", Price = 20, Description = "Shows what the future may be" },
                new Art { ArtistID = 7, Title = "Ava", Price = 20, Description = "A blend of colours" },
                new Art { ArtistID = 8,  Title = "William", Price = 20, Description = "A portrait of a women" },
                new Art { ArtistID = 9,  Title = "Isabella", Price = 20, Description = "Luciousness" },
                new Art { ArtistID = 10,  Title = "Liam", Price = 20, Description = "The baldie himself" },
            };
            foreach (Art a in arts)
            {
                context.Art.Add(a);
            }
            context.SaveChanges();
            ;



            var purchaseorders = new PurchaseOrder[]
          {
              new PurchaseOrder { ArtID = 1, CustomerID = 1, OrderCost = 100, OrderDate = DateTime.Parse("2025-10-11"), StartingDate = DateTime.Parse("2025-10-14"), FinishDate = DateTime.Parse("2025-10-18") },
              new PurchaseOrder { ArtID = 2, CustomerID = 2, OrderCost = 20, OrderDate = DateTime.Parse("2025-06-10"), StartingDate = DateTime.Parse("2025-06-14"), FinishDate = DateTime.Parse("2025-06-16") },
              new PurchaseOrder { ArtID = 3, CustomerID = 3, OrderCost = 40, OrderDate = DateTime.Parse("2025-08-02"), StartingDate = DateTime.Parse("2025-08-05"), FinishDate = DateTime.Parse("2025-08-08") },
              new PurchaseOrder { ArtID = 4, CustomerID = 4, OrderCost = 55, OrderDate = DateTime.Parse("2025-06-08"), StartingDate = DateTime.Parse("2025-06-10"), FinishDate = DateTime.Parse("2025-06-14") },
              new PurchaseOrder { ArtID = 5, CustomerID = 5, OrderCost = 25, OrderDate = DateTime.Parse("2025-01-01"), StartingDate = DateTime.Parse("2025-01-04"), FinishDate = DateTime.Parse("2025-01-08") },
              new PurchaseOrder { ArtID = 6, CustomerID = 6, OrderCost = 70, OrderDate = DateTime.Parse("2025-04-21"), StartingDate = DateTime.Parse("2025-04-23"), FinishDate = DateTime.Parse("2025-04-26") },
              new PurchaseOrder { ArtID = 7, CustomerID = 7, OrderCost = 15, OrderDate = DateTime.Parse("2025-06-24"), StartingDate = DateTime.Parse("2025-06-28"), FinishDate = DateTime.Parse("2025-06-30") },
              new PurchaseOrder { ArtID = 8, CustomerID = 8, OrderCost = 90, OrderDate = DateTime.Parse("2025-11-11"), StartingDate = DateTime.Parse("2025-11-14"), FinishDate = DateTime.Parse("2025-1-18") },
              new PurchaseOrder { ArtID = 9, CustomerID = 9, OrderCost = 45, OrderDate = DateTime.Parse("2025-06-18"), StartingDate = DateTime.Parse("2025-06-22"), FinishDate = DateTime.Parse("2025-06-24") },
              new PurchaseOrder { ArtID = 10, CustomerID = 10, OrderCost = 60, OrderDate = DateTime.Parse("2025-4-11"), StartingDate = DateTime.Parse("2025-04-14"), FinishDate = DateTime.Parse("2025-04-18") },
          };
            foreach (PurchaseOrder p in purchaseorders)
            {
                context.PurchaseOrder.Add(p);
            }
            context.SaveChanges();



            var rentals = new Rental[]
            {
                new Rental { ArtID = 1, CustomerID = 1, RentalCost = 100, RentalDate = DateTime.Parse("2025-02-14"), RentalFinishDate = DateTime.Parse("2025-02-18") },
                new Rental { ArtID = 2, CustomerID = 2, RentalCost = 150, RentalDate = DateTime.Parse("2025-03-13"), RentalFinishDate = DateTime.Parse("2025-03-17") },
                new Rental { ArtID = 3, CustomerID = 3, RentalCost = 400, RentalDate = DateTime.Parse("2025-06-09"), RentalFinishDate = DateTime.Parse("2025-06-11") },
                new Rental { ArtID = 4, CustomerID = 4, RentalCost = 350, RentalDate = DateTime.Parse("2025-07-21"), RentalFinishDate = DateTime.Parse("2025-07-24") },
                new Rental { ArtID = 5, CustomerID = 5, RentalCost = 200, RentalDate = DateTime.Parse("2025-11-17"), RentalFinishDate = DateTime.Parse("2025-11-21") },
                new Rental { ArtID = 6, CustomerID = 6, RentalCost = 250, RentalDate = DateTime.Parse("2025-05-02"), RentalFinishDate = DateTime.Parse("2025-05-05") },
                new Rental { ArtID = 7, CustomerID = 7, RentalCost = 100, RentalDate = DateTime.Parse("2025-01-18"), RentalFinishDate = DateTime.Parse("2025-01-21") },
                new Rental { ArtID = 8, CustomerID = 8, RentalCost = 450, RentalDate = DateTime.Parse("2025-01-17"), RentalFinishDate = DateTime.Parse("2025-01-20") },
                new Rental { ArtID = 9, CustomerID = 9, RentalCost = 400, RentalDate = DateTime.Parse("2025-02-12"), RentalFinishDate = DateTime.Parse("2025-02-16") },
                new Rental { ArtID = 10, CustomerID = 10, RentalCost = 350, RentalDate = DateTime.Parse("2025-04-06"), RentalFinishDate = DateTime.Parse("2025-04-11") },
            };
            foreach (Rental r in rentals)
            {
                context.Rental.Add(r);
            }
            context.SaveChanges();

             var exhibitions = new Exhibition[]
            {
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-11-11"), FinishDate = DateTime.Parse("2025-11-15") },
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-12-11"), FinishDate = DateTime.Parse("2025-12-15") },
                new Exhibition { GalleryName = "Chirstchurch Gallery", City = "Christchurch", Zip = 1011, Country = "New Zealand", StartingDate = DateTime.Parse("2025-06-08"), FinishDate = DateTime.Parse("2025-06-14") },
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-08-11"), FinishDate = DateTime.Parse("2025-08-14") },
                new Exhibition { GalleryName = "Chirstchurch Gallery", City = "Chirstchurch", Zip = 1011, Country = "New Zealand", StartingDate = DateTime.Parse("2025-04-09"), FinishDate = DateTime.Parse("2025-04-15") },
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-06-11"), FinishDate = DateTime.Parse("2025-06-12") },
                new Exhibition { GalleryName = "Wellington Gallery", City = "Wellington", Zip = 6000, Country = "New Zealand", StartingDate = DateTime.Parse("2025-06-04"), FinishDate = DateTime.Parse("2025-06-06") },
                new Exhibition { GalleryName = "Wellington Gallery", City = "Wellington", Zip = 6000, Country = "New Zealand", StartingDate = DateTime.Parse("2025-10-06"), FinishDate = DateTime.Parse("2025-10-08") },
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-06-20"), FinishDate = DateTime.Parse("2025-06-24") },
                new Exhibition { GalleryName = "Auckland Gallery", City = "Auckland", Zip = 1400, Country = "New Zealand", StartingDate = DateTime.Parse("2025-08-24"), FinishDate = DateTime.Parse("2025-08-28") },
            };
            foreach (Exhibition e in exhibitions)
            {
                context.Exhibition.Add(e);
            }
            context.SaveChanges();

        }
    }
}

        
    
