namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

public interface IUnitOfWork
{
    IAuthRepository AuthRepository { get; }
    IBlogRepository BlogRepository { get; }
}