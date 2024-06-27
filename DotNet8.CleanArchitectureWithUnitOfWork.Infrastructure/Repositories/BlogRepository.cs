namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories;

public class BlogRepository : IBlogRepository
{
    private readonly AppDbContext _context;

    public BlogRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<Result<BlogResponseModel>> GetBlog(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<BlogListResponseModel>> GetBlogs()
    {
        Result<BlogListResponseModel> responseModel;
        try
        {
            var lst = await _context.TblBlogs
                .OrderByDescending(x => x.BlogId)
                .ToListAsync();

            var model = new BlogListResponseModel { Blogs = lst.Select(x => x.Change()).ToList() };

            responseModel = Result<BlogListResponseModel>.SuccessResult(model);
        }
        catch (Exception ex)
        {
            responseModel = Result<BlogListResponseModel>.FailureResult(ex);
        }

        return responseModel;
    }
}