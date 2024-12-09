using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed record DeleteUserRequest(Guid Id) : IRequest<DeleteUserResponse>;

