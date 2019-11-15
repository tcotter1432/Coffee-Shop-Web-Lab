using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18.Models
{
    public class Registrant
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(48, MinimumLength = 8)]
        public string Password { get; set; }
        [Range(typeof(DateTime), "1/1/1900", "11/14/2001", ErrorMessage = "Age not Valid!")]
        public DateTime DOB { get; set; }
        

    }
}
