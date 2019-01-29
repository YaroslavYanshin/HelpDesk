using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    //модель отдела(цеха)
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название отдела(цеха)")]
        [MaxLength(50,ErrorMessage = "Привышена максимальная длина записи")]
        public string Name { get; set; }

    }
}