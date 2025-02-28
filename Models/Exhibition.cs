namespace Art_Exhibition_Project.Models
{
    public class Exhibition
    {
        public int ExhibitionID { get; set; }
        public string GalleryName { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishDate { get; set; }

    }
}
