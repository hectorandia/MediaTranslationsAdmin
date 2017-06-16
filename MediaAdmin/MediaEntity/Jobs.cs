namespace MediaAdmin.MediaEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jobs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string SourceLanguage { get; set; }

        [StringLength(50)]
        public string TargetLanguage1 { get; set; }

        [StringLength(50)]
        public string TargetLanguage2 { get; set; }

        [StringLength(50)]
        public string TargetLanguage3 { get; set; }

        [StringLength(50)]
        public string TargetLanguage4 { get; set; }

        [StringLength(50)]
        public string TargetLanguage5 { get; set; }

        [StringLength(50)]
        public string TargetLanguage6 { get; set; }

        [StringLength(50)]
        public string TargetLanguage7 { get; set; }

        public virtual Customers Customers { get; set; }
    }
}
