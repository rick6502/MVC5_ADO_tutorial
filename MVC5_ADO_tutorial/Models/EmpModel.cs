using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MVC5_ADO_tutorial.Models
{
    public class EmpModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FName
        {
            get;
            set;
        }
        [Display(Name = "Middle Name")]
        public string MName
        {
            get; set;

        }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LName
        {
            get; set;
        }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid emaild address")]
        [Required(ErrorMessage = "Emailld is required.")]
        public string EmailId
        {
            get; set;
        }
    }
}