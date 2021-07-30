namespace 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberID { get; set; }

        public int StockNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
