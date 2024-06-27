using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAuthRepository AuthRepository { get; }
        IBlogRepository BlogRepository { get; }
    }
}
