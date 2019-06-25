using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class UserDetail
    {
        public string userName { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string emailAddress { get; set; }

        public bool isActive { get; set; }

        public string fullName { get; set; }

        public DateTime lastLoginTime { get; set; }

        public DateTime creationTime { get; set; }

        public string[] roleNames { get; set; }

        public int id { get; set; }
    }
}
