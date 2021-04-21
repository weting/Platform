using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Model
{
    public class CompanyInfo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Account { get; set; } 
        [Required]
        public string Password { get; set; }
        [Required]
        public string CpyName { get; set; }
        [Required]
        public string CpyOwner { get; set; }
        [Required]
        public string OwnerID { get; set; }
        [Required]
        public string Identifier { get; set; }        
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Cellphone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
