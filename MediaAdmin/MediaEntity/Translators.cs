namespace MediaAdmin.MediaEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Translators
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TranslatorID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string ZIP { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string FirstLanguage { get; set; }

        [StringLength(50)]
        public string SecondLanguage { get; set; }

        [StringLength(50)]
        public string ThirdLanguage { get; set; }

        [StringLength(50)]
        public string FourthLanguage { get; set; }
    }
}
