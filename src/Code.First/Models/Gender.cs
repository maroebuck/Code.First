using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code.First.Models
{
    public class Gender
    {
        [Key]
        public short GenderId { get; set; }

        [StringLength(6)]
        public string GenderName { get; set; }

    }
}
