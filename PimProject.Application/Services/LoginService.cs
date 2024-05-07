using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Services
{
    public class LoginService : ILoginService
    {
        public LoginService() 
        { 
        }


        public Task<bool> ExecutarLogin(LoginResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
