using System.ComponentModel.DataAnnotations;

namespace Art_Exhibition_Project.Models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int ArtID { get; set; }
        public int CustomerID { get; set; }


        //price of the order has to be between $10 - $1000//
        [Required]
        [Range(10, 1000, ErrorMessage = "Please enter a vaild order cost ($10 - $1000)")]
        [Display(Name = "OrderCost")]
        public int OrderCost { get; set; }

        //this is the date of order//
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        //this is the date of the start of the order//
        [Display(Name = "Estimated Starting Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartingDate { get; set; }

        //this is the date of the end of the order//
        [Display(Name = "Estimated Ending Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FinishDate { get; set; }
        public Art Art { get; set; }
        public Customer Customer { get; set; }

    }
}
