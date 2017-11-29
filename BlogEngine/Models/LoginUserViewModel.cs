using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEngine.Models
{
    public class LoginUserViewModel
    {
        public Login Login { get; set; }
        public User User { get; set; }
    }
}