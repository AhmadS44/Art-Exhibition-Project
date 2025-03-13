namespace Art_Exhibition_Project.Models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int ArtID { get; set; }
        public int CustomerID { get; set; }

        public int OrderCost { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Art Art { get; set; }
        public Customer Customer { get; set; }

    }
}
