using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class LoginResult
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public int UserId { get; set; }
    }
}
