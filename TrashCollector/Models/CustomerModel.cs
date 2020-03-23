using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerModel
    {
        [Key]
        public int PrimaryKey { get; set; }

        public string FirstName { get; set; }
        public string LatName { get; set; }
        public string PickUpDate { get; set; }
        public string ExtraPickUpDate { get; set; }
        public double AmountOwed { get; set; }
        public string StartOfCycle { get; set; }
        public string EndOfCycle { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
