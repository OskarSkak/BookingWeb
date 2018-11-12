﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platibus.Web.DataServices.Models.User
{
    public class UpdateUserModel
    {
        public UpdateUserModel(string name, string email, string password, int accesLevel)
        {
            Name = name;
            Email = email;
            Password = password;
            AccessLevel = accesLevel;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }
    }
}