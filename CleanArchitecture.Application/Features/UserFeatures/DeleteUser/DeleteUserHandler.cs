using MediatR;      
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using AutoMapper;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;
public sealed class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public DeleteUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        _userRepository.Delete(user);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<DeleteUserResponse>(user);
    }
}
