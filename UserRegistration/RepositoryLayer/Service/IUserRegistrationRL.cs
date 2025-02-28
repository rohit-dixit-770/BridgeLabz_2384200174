using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public interface IUserRegistrationRL
    {
        bool RegistrationRL(string username, string password);
    }
}
