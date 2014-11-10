using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WpcabAdministration.Models
{
    public class Relative
    {
        [Key]
        public int RelativeId { get; set; }

        public int MemberId { get; set; }

        [Display(Name = "Name")]
        public string NameEn { get; set; }

        [Display(Name = "নাম")]
        public string NameBn { get; set; }
    }
}