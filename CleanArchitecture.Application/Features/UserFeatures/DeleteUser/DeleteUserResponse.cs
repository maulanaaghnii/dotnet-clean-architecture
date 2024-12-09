using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed record DeleteUserResponse
{
    public Guid id { get; set; }
}
