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

            var arts = new Art[]
            {
           new Art {Title= "Daniel", Price=20, Description="Danielpatel@gmail.com"},
           new Art {Title= "Emily", Price=10, Description="emilyj@gmail.com"},
           new Art {Title= "Sophia", Price=-10, Description="Swilliams22@gmail.com"},
           new Art {Title= "Ethan", Price=20, Description="ethanB@gmail.com"},
           new Art {Title= "Olivia", Price=20, Description="oliviaDa88@gmail.com"},
           new Art {Title= "Jacob", Price=20, Description="jacobMartinez22@gmail.com"},
           new Art {Title= "Ava", Price=20,  Description="avag9@gmail.com"},
           new Art {Title= "William", Price=20, Description="williamj21@gmail.com"},
           new Art {Title= "Isabella", Price=20, Description="irodriguez2@gmail.com"},
            new Art { Title = "Liam", Price = 20, Description = "liamanderson0@gmail.com" },
            };
            foreach (Art a in arts)
            {
                context.Art.Add(a);
            }
            context.SaveChanges();
            ;

            var artists = new Artist[]
             {
           new Artist {FirstName= "William", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Yamaha MT-09", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Harley-Davidson Fat Boy", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Kawasaki Z900", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Suzuki Hayabusa", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Ducati Monster", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "BMW R1250GS", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Triumph Bonneville T120", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "KTM 390 Duke", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
           new Artist {FirstName= "Aprilia Tuono V4", LastName= "William", Address= "William", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0216421822},
              };
            foreach (Artist a in artists)
            {
                context.Artist.Add(a);
            }
            context.SaveChanges();


            var customers = new Customer[]
            {
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
           new Customer {FirstName= "Bob", LastName= "Man", Address= "25Road", City= "25Road", Zip=1979, Country="New Zealand", PhoneNumber= 0212826062, Email="connorm1@gmail.com"},
            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();


            var exhibitions = new Exhibition[]
            {
           new Exhibition {GalleryName="AucklandGallery", City="Auckland", Zip=1021, Country="New Zealand", StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=0624, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Christchurch", Zip=8011, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=1024, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=1011, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=0622, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Wellington",  Zip=6012, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Wellington",  Zip=6011, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=1010, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
           new Exhibition {GalleryName="AucklandGallery", City="Auckland",  Zip=1052, Country="New Zealand" , StartingDate=DateTime.Parse("2002-06-11"), FinishDate=DateTime.Parse("2002-06-12")},
            };
            foreach (Exhibition e in exhibitions)
            {
                context.Exhibition.Add(e);
            }
            context.SaveChanges();

            var suppliers = new Supplier[]
          {
           new Supplier {LocationID= 1, InventoryID=1, FirstName="Natalie", LastName= "Reynolds", PhoneNumber=0212772612, Email="nataliereynolds@gmail.com", City="Auckland", Address="42 Pine Street, Grey Lynn", Zip=1021},
           new Supplier {LocationID= 2, InventoryID=2, FirstName="Connor", LastName= "Mitchell", PhoneNumber=0218273672, Email="connorm1@gmail.com", City="Auckland", Address="15 Ocean Avenue, Devonport", Zip=0624},
           new Supplier {LocationID= 3, InventoryID=3, FirstName="Harper", LastName= "Evans", PhoneNumber=0219283714, Email="harperevan22@gmail.com", City="Christchurch", Address="25 Cathedral Square, Christchurch Central", Zip=8011},
           new Supplier {LocationID= 4, InventoryID=4, FirstName="Sebastian", LastName= "Hayes", PhoneNumber=0212928371, Email="sebastianH2@gmail.com", City="Auckland", Address="28 Elm Road, Mount Eden", Zip=1024},
           new Supplier {LocationID= 5, InventoryID=5, FirstName="Madison", LastName= "Clarke", PhoneNumber=0219817378, Email="MadisonCl@gmail.com", City="Auckland", Address="9 Harbour View Terrace, Herne Bay", Zip=1011},
           new Supplier {LocationID= 6, InventoryID=6, FirstName="Logan", LastName= "Ramirez", PhoneNumber=0219823598, Email="loganramirez222@gmail.com", City="Auckland", Address="56 Beach Road, Takapuna", Zip=0622},
           new Supplier {LocationID= 7, InventoryID=7, FirstName="Harper", LastName= "Nguyen", PhoneNumber=0219238533, Email="harperisme21@gmail.com", City="Wellington", Address="7 Kelburn Parade, Kelburn", Zip=6012},
           new Supplier {LocationID= 8, InventoryID=8, FirstName="Benjamin", LastName= "Campbell", PhoneNumber=0212718372, Email="benny281@gmail.com", City="Wellington", Address="18 Lamton Quay, Wellington Central", Zip=6011},
           new Supplier {LocationID= 9, InventoryID=9, FirstName="Stella", LastName= "Thompson", PhoneNumber=0204329023, Email="stellaswork22@gmail.com", City="Auckland", Address="37 Queen Street, Auckland Central", Zip=1010},
           new Supplier {LocationID= 10, InventoryID=10, FirstName="Carter", LastName= "Morgan", PhoneNumber=0213570928, Email="morgansur22@gmail.com", City="Auckland", Address="63 Hillside Road, Parnell", Zip=1052},
          };
            foreach (Supplier s in suppliers)
            {
                context.Supplier.Add(s);
            }
            context.SaveChanges();



            var purchaseorders = new PurchaseOrder[]
            {
           new PurchaseOrder {CustomerID= 1, PurchaseDate=DateTime.Parse("2002-06-11"), Model="Yamaha MT-07", Zip=1021, PhoneNumber=0217817819},
           new PurchaseOrder {CustomerID= 2, PurchaseDate=DateTime.Parse("2004-01-12"), Model="Honda Africa Twin", Zip=0624, PhoneNumber=0282185312},
           new PurchaseOrder {CustomerID= 3, PurchaseDate=DateTime.Parse("2001-09-08"), Model="Suzuki V-Strom", Zip=8011, PhoneNumber=0219218815},
           new PurchaseOrder {CustomerID= 4, PurchaseDate=DateTime.Parse("2010-12-06"), Model="Kawasaki Versys", Zip=1024, PhoneNumber=0217927992},
           new PurchaseOrder {CustomerID= 5, PurchaseDate=DateTime.Parse("2007-07-02"), Model="Harley-Davidson", Zip=1011, PhoneNumber=0217242918},
           new PurchaseOrder {CustomerID= 6, PurchaseDate=DateTime.Parse("2006-02-08"), Model="BMW R nineT", Zip=1021, PhoneNumber=0211292413},
           new PurchaseOrder {CustomerID= 7, PurchaseDate=DateTime.Parse("2014-04-07"), Model="Triumph Tiger", Zip=6012, PhoneNumber=0212972816},
           new PurchaseOrder {CustomerID= 8, PurchaseDate=DateTime.Parse("2011-11-07"), Model="Ducati Multistrada", Zip=6011, PhoneNumber=0217238215},
           new PurchaseOrder {CustomerID= 9, PurchaseDate=DateTime.Parse("2009-04-01"), Model="KTM 690 Enduro R", Zip=8011, PhoneNumber=0212292718},
           new PurchaseOrder {CustomerID= 10, PurchaseDate=DateTime.Parse("2012-06-05"), Model="Aprilia Caponord 1200", Zip=6011, PhoneNumber=0212923819},
            };
            foreach (PurchaseOrder p in purchaseorders)
            {
                context.PurchaseOrder.Add(p);
            }
            context.SaveChanges();

        }
    }
