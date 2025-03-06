using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace BusinessLayer.Interface
{
    public interface IRegisterHelloBL
    {
        Task<string> LoginUser(LoginDTO loginDTO);
        Task<RegistrationResponse> RegisterBL(RegisterDTO registerDTO);
    }
}
