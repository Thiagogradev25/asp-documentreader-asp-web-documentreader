using ASP_WEB_DocumentReader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WEB_DocumentReader.Domain.Core.Interfaces
{
    public interface ILoginService
    {
        LoginResponse User { get; }
        Task Initialize();
        Task Login(LoginRequest model);
        Task Logout();
    }
}
