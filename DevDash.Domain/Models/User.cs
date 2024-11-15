﻿using DevDash.Domain.BaseModels;

namespace DevDash.Domain.Models
{
    public class User : DashObject
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
}
