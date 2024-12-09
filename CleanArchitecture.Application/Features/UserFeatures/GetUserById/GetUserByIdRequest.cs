
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetUserById;

public sealed record GetUserByIdRequest : IRequest<GetUserByIdResponse>
{
    public Guid Id { get; set; }
}
