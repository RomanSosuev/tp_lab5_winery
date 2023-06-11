using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplicationLab5True.Models
{
    public class WineryModel
    {
        [Display(Name = "Grape")]
        public string Grape { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "WineName")]
        public string WineName { get; set; }

        [Display(Name = "HarvestDate")]
        [DataType(DataType.Date)]
        public DateTime HarvestDate { get; set; }

        [Display(Name = "Alcohol")]
        public float Acl { get; set; }

        [Display(Name = "WineID")]
        public int ID { get; set; }



    }
}