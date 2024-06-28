using Microsoft.Extensions.DependencyInjection;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IAuthRepository _authRepository;

    private IBlogRepository _blogRepository;

    private readonly IServiceProvider _serviceProvider;

    public UnitOfWork(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IAuthRepository AuthRepository =>
        _authRepository ??= _serviceProvider.GetRequiredService<IAuthRepository>();

    public IBlogRepository BlogRepository =>
        _blogRepository ??= _serviceProvider.GetRequiredService<IBlogRepository>();
}
