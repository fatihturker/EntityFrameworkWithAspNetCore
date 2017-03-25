using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkWithAspNetCore.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string Name { get; set; }
        [Required, StringLength(64)]
        public string Surname { get; set; }
        public float Age { get; set; }
        [Required, StringLength(256)]
        public string Email { get; set; }
    }
}
