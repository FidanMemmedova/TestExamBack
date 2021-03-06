using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeternaBack.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public string Description { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
