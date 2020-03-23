using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Sample
    {
        [Key]
        public int PrimaryKey { get; set; }
        
        public string Name { get; set; }
        public string UserId { get; set; }
    }
}
