﻿namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;

    public AuthRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Result<AuthResponseModel>> Login(LoginRequestModel requestModel)
    {
        throw new NotImplementedException();
    }

    public Task<Result<AuthResponseModel>> Register(RegisterRequestModel requestModel)
    {
        throw new NotImplementedException();
    }
}
