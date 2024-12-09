using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using Moq;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class CreateUserHandlerTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly CreateUserHandler _handler;

        public CreateUserHandlerTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockUserRepository = new Mock<IUserRepository>();
            _mockMapper = new Mock<IMapper>();
            _handler = new CreateUserHandler(_mockUnitOfWork.Object, _mockUserRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task Handle_ShouldCreateUserAndReturnResponse()
        {
            // Arrange
            var request = new CreateUserRequest("test@example.com", "Test User", "1234567890");
            var user = new User { Email = request.Email, Name = request.Name, Phone = request.Phone };
            var response = new CreateUserResponse { Id = Guid.NewGuid(), Email = user.Email, Name = user.Name, Phone = user.Phone };

            _mockMapper.Setup(m => m.Map<User>(request)).Returns(user);
            _mockMapper.Setup(m => m.Map<CreateUserResponse>(user)).Returns(response);

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            _mockUserRepository.Verify(r => r.Create(user), Times.Once);
            _mockUnitOfWork.Verify(u => u.Save(CancellationToken.None), Times.Once);
            Assert.Equal(response, result);
        }
    }
}
