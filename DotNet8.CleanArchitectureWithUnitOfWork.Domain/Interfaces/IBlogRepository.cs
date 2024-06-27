namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;

public interface IBlogRepository
{
    Task<Result<BlogListResponseModel>> GetBlogs();
    Task<Result<BlogResponseModel>> GetBlog(int id);
}
