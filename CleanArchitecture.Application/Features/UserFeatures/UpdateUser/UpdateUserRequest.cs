using MediatR;
namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser
{
    public sealed record UpdateUserRequest(Guid Id,string Email, string Name, string Phone) : IRequest<UpdateUserResponse>;
}
