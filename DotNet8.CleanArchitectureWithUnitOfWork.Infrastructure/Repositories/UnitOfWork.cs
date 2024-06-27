namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IAuthRepository _authRepository;

    private IBlogRepository _blogRepository;

    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IAuthRepository AuthRepository => _authRepository ??= new AuthRepository(_context);

    public IBlogRepository BlogRepository => _blogRepository ??= new BlogRepository(_context);
}