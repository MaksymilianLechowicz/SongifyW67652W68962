using Songify.Functionality.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songify.Functionality.Interface
{
    public interface IUserService
    {
        bool Register(RegisterRequest request);
        bool Login(LoginRequest request);
    }
}
