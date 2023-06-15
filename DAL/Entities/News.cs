using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class News : _base
    {
        [Required]
        public string TitleAr { get; set; }


        [Required]
        public string TitleEn { get; set; }


        [Required]
        public string ContentAr { get; set; }


        [Required]
        public string ContentEn { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime publishDate { get; set; }
        public Photo pic { get; set; }



    }
}
