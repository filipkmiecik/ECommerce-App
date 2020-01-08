using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        [StringLength(100, ErrorMessage = "Username is too long")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [StringLength(100, ErrorMessage = "Email is too long")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Message is required")]
        [StringLength(5000, ErrorMessage = "Message is too long")]
        public string Message { get; set; }
        public bool WaitForAnAnswer { get; set; }
    }
}
