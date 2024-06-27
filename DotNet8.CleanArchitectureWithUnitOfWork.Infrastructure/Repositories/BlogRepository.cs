﻿using DotNet8.CleanArchitectureWithUnitOfWork.Api;
using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Interfaces;
using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models;
using DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog;
using DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.Repositories
{
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
}
