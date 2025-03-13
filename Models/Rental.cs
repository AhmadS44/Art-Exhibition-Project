namespace Art_Exhibition_Project.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int ArtID { get; set; } // foreign key
        public int CustomerID { get; set; } // foreign key
        public int RentalCost { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalFinishDate { get; set; }
        public Art Art { get; set; }
        public Customer Customer { get; set; }

    }
}
