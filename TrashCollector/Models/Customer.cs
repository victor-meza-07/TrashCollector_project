﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int PrimaryKey { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
