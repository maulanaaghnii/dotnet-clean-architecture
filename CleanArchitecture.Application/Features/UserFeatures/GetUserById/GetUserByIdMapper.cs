using AutoMapper;
using CleanArchitecture.Domain.Entities;
namespace CleanArchitecture.Application.Features.UserFeatures.GetUserById;

public sealed class GetUserByIdMapper : Profile
{
    public GetUserByIdMapper()
    {
        CreateMap<User, GetUserByIdResponse>();
    }
}
