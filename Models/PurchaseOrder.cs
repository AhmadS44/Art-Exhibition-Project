namespace Art_Exhibition_Project.Models
{
    public class PurchaseOrder
    {
        public int OrderID { get; set; }
        public int OrderCost { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishDate { get; set; }

    }
}
