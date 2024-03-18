using PazaryeriTrello.Helpers;
using PazaryeriTrello.Models;
using PazaryeriTrello.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Interfaces
{
    public interface IAccountService
    {
        public LoginResponse Login(LoginRequest request);
    }
}
