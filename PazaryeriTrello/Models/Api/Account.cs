using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Models.Api
{
    public class Account
    {
    }

    public class LoginRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PassWord { get; set; }
    }

    public class LoginResponse : ResponseBase 
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
