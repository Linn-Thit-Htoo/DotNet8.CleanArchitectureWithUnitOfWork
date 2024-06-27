namespace DotNet8.CleanArchitectureWithUnitOfWork.Api.Features.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
    private IUnitOfWork _unitOfWork;

    public BlogController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetBlogs()
    {
        try
        {
            var result = await _unitOfWork.BlogRepository.GetBlogs();
            return Content(result);
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}
