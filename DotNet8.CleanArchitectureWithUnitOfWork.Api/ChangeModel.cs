namespace DotNet8.CleanArchitectureWithUnitOfWork.Api;

public static class ChangeModel
{
    public static BlogModel Change(this TblBlog dataModel)
    {
        return new BlogModel
        {
            BlogId = dataModel.BlogId,
            BlogTitle = dataModel.BlogTitle,
            BlogAuthor = dataModel.BlogAuthor,
            BlogContent = dataModel.BlogContent
        };
    }
}