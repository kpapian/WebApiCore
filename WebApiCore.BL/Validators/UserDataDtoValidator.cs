using FluentValidation;
using WebApiCore.BL.Models;

namespace WebApiCore.BL.Validators
{
    public class UserDataDtoValidator : AbstractValidator<UserDataDto>
    {
        public UserDataDtoValidator()
        {
            RuleFor(p => p.UserText).NotEmpty();
            RuleFor(p => p.UserId).NotEmpty();
        }
    }
}
