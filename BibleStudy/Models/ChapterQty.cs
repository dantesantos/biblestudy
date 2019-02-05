namespace BibleStudy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChapterQty")]
    public partial class ChapterQty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuthorID { get; set; }

        [Required]
        [StringLength(50)]
        public string AuthorName { get; set; }

        public int Qty { get; set; }
    }
}
