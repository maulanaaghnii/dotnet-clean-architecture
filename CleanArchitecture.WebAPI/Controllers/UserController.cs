using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Features.UserFeatures.DeleteUser;
using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.Application.Features.UserFeatures.GetUserById;
using CleanArchitecture.Application.Features.UserFeatures.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
        return Ok(response);
    }
    
    
    [HttpGet("{id}")]
    public async Task<ActionResult<List<GetUserByIdResponse>>> GetUserById(Guid Id, CancellationToken cancellationToken)
    {
        var request = new GetUserByIdRequest { Id = Id };
        var response = await _mediator.Send(request, cancellationToken);
        if (response == null)
        {
            return NotFound();
        }
        return Ok(response);
    }
    
    
    
    [HttpPost]
    public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);

        
    }

    [HttpPut]
    public async Task<ActionResult<UpdateUserResponse>> Update(UpdateUserRequest request, 
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request,cancellationToken);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult<DeleteUserResponse>> Delete(DeleteUserRequest request, 
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send<DeleteUserResponse>(request, cancellationToken);
        return Ok(response);
    }
}