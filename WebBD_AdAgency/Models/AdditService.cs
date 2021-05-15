using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBD_AdAgency.Models
{
    public class AdditService
    {
        [Display(Name = "Код услуги")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
    }
}
