using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using HelpDesk.Controllers;
using HelpDesk.Models;
using HelpDesk.Providers;
using HelpDesk.Enums;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDesk.Models
{
    public class LogViewModel
    {

        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
}