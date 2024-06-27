namespace DotNet8.CleanArchitectureWithUnitOfWork.Domain.Enums;

public enum EnumStatusCode
{
    Success = 200,
    Created = 201,
    Accepted = 202,
    BadRequest = 400,
    NotFound = 404,
    Duplicate = 409,
    InternalServerError = 500
}
