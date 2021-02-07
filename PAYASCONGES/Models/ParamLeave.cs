using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAYASCONGES.Models
{
    public class ParamLeave
    {
        [Required]
        public int Id{ get; set; }
        [MaxLength(15,ErrorMessage ="Max lengh is 15")]
        [MinLength(2,ErrorMessage ="min lengi est 2"]
        public string Labelparam { get; set; }

        
    }
}