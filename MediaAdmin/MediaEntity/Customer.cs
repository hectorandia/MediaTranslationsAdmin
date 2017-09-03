namespace MediaAdmin.MediaEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Customer
    {
        public SelectList CustomerTypList = new SelectList(new string[] { "Private", "Company"});

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Jobs = new HashSet<Job>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [HiddenInput(DisplayValue = false)]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a customer name")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [StringLength(50)]
        public string ZIP { get; set; }
       
        
        [StringLength(50, ErrorMessage ="Select a Country", MinimumLength = 2)]
        public string Country { get; set; }

        [Display(Name = "Email address")]
        //[Required(ErrorMessage = "Please enter a customer email address")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(20)]
        public string CustomerTyp { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [Phone(ErrorMessage ="Invalid Phone number")]
        [StringLength(30)]
        public string CellPhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public string State { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Added { get; set; }

        [StringLength(30)]
        public string FirstLanguage { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
