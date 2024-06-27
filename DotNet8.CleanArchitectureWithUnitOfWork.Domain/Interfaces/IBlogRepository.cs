using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models;
using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces
{
    public interface IBlogRepository
    {
        Task<Result<BlogListResponseModel>> GetBlogs();
        Task<Result<BlogResponseModel>> GetBlog(int id);
    }
}
