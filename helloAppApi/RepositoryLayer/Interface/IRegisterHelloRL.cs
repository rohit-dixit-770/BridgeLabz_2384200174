using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IRegisterHelloRL
    {
        Task<string> Login(LoginDTO login);
        Task<UserEntity> Registration(RegisterDTO registerDTO);
        public Task<string> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO);
        public Task<bool> ResetPassword(ResetPasswordDTO resetPasswordDTO);
    }
}
