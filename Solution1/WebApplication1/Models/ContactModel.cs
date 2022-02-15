using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "پر کردن این فیلد الزامی است !")]
        [MinLength(3,ErrorMessage = "حداقل 3 کاراکتر")]
        [MaxLength(100,ErrorMessage = "حداکثر 100 کاراکتر")]
        public string Name { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد الزامی است")]
        [EmailAddress(ErrorMessage = "آدرس ایمیل صحیح نیست!")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
        
    }
}
