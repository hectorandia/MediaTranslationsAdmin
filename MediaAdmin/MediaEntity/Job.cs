namespace MediaAdmin.MediaEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.DateTime)]
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

        [StringLength(50)]
        public string Payment { get; set; }

        
        public decimal? Value { get; set; }

        /// <summary>
        /// Existen 4 tipos de status
        /// 1 = Abierto
        /// 2 = Cerrado
        /// 3 = Reclamacion
        /// 4 = en Espera
        /// </summary>
        public int Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Added { get; set; }

        public virtual Customer Customers { get; set; }
    }
}
