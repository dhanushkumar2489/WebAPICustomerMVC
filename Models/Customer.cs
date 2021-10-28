using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreMVCCustomerEx.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public string CCity { get; set; }
        public string CProfilePic { get; set; }
        [NotMapped]
        public IFormFile CPicFile { get; set; }
    }
}
