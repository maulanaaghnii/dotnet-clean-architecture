namespace CleanArchitecture.Application.Features.UserFeatures.GetUserById;

public sealed record GetUserByIdResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}
