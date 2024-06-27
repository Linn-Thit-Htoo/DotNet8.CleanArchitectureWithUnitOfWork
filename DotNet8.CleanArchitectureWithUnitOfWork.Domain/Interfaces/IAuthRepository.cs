namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

public interface IAuthRepository
{
    Task<Result<AuthResponseModel>> Login(LoginRequestModel requestModel);
    Task<Result<AuthResponseModel>> Register(RegisterRequestModel requestModel);
}