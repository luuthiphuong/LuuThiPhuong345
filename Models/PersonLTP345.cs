using System;
using System.ComponentModel.DataAnnotations;

namespace LuuThiPhuong345.Models
{
    public class PersonLTP345
    {
        [Key]
        [Display(Name = "ID người dùng")]
        public int PersonId { get; set; }
        [Display(Name = "Tên người dùng")]
        public string PersonName { get; set; }
    }
}