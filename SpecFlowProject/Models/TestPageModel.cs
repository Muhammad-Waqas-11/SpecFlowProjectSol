using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecFlowProject.Models
{
    public class TestPageModel
    {
        
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public DateTime? DOB { get; set; } // Nullable for optional date of birth

        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]([0-9]{3})[-. ]([0-9]{4})$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        public string Occupation { get; set; }
    }

}