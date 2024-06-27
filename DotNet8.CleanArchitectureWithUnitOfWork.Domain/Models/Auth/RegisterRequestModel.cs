namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Models.Auth;

public class RegisterRequestModel
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserRole { get; set; }
}
