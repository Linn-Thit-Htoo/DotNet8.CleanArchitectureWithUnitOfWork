﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Auth
{
    public class UserModel
    {
        public string UesrId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get;set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
    }
}
