using System;
using System.ComponentModel.DataAnnotations;

namespace LuuThiPhuong345.Models
{
    public class LTP0345
    {
        [Key]
        public int LTPId { get; set; }
        public string LTPName { get; set; }
        public string LTPGender { get; set; }
    }
}