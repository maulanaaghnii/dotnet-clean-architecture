using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserRequest(string Email, string Name, string Phone) : IRequest<CreateUserResponse>;