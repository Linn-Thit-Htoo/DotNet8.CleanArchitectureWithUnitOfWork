using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Blog
{
    public class BlogModel
    {
        public int BlogId { get; set; }

        public string? BlogTitle { get; set; }

        public string? BlogAuthor { get; set; }

        public string? BlogContent { get; set; }
    }
}
