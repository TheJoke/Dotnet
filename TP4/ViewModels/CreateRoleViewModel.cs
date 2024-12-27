﻿using System.ComponentModel.DataAnnotations;

namespace UserWebApp.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]

        public string RoleName { get; set; }

    }
}
