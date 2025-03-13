namespace Art_Exhibition_Project.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Art> Art { get; set; }
    }
}
