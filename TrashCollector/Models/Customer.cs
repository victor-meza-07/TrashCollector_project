using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int PrimaryKey { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public DateTime PickUpDate { get { return PickUpDate.Date; } set { PickUpDate = value.Date; } }
        public bool ExtraPickUpUsed { get; set; } = false;
        public double AmountOwed { get; set; } = 0.0;
        public DateTime StartOfCycle { get { return StartOfCycle.Date; } set { StartOfCycle = value.Date; } }
        public DateTime EndOfCycle { get { return EndOfCycle.Date; } set { EndOfCycle = value.Date; } }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
