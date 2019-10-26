using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class Employee1
    {
   

        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Name { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string Designation { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(11)")]
        public int  Code { get; set; }
        
        [Required]
        [Column(TypeName = "Varchar(max)")]
        public string Address { get; set; }



    }
}
