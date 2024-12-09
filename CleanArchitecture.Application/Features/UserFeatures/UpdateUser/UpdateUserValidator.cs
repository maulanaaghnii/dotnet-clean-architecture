using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser
{
    public sealed class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Phone).NotEmpty().MinimumLength(3).MaximumLength(13);
        }
    }
}
