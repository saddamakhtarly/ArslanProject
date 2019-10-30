﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models.Address
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public virtual Province Province { get; set; }


    }
}
