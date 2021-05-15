using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBD_AdAgency.Models
{
    public class Location
    {
        [Display(Name = "Код места")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Расположение")]
        public string Address { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
        [Display(Name = "Код вида")]
        public long TypeAdID { get; set; }
        [Display(Name = "Вид")]
        public TypeAd TypeAd { get; set; }
    }
}
