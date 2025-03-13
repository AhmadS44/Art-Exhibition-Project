namespace Art_Exhibition_Project.Models
{
    public class Art
    {
        public int ArtId { get; set; }
        public int ArtistID { get; set; } // foreign key
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        
        public Artist Artist { get; set; }
        public ICollection<Rental> Rental { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }

    }
}
