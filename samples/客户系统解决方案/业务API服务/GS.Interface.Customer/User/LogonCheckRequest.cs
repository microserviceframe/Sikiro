﻿using System.ComponentModel.DataAnnotations;

namespace Sikiro.Interface.Customer.User
{
    public class LogonCheckRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string CompanyId { get; set; }
    }
}
