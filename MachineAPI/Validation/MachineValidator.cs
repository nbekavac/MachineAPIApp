using FluentValidation;
using DataAcces.Models;
using FluentValidation.AspNetCore;

namespace MachineAPI.Validation
{
    public class MachineValidator:AbstractValidator<MachineModel>
    {
        
        public MachineValidator()
        {
            //Rule for same naming
            //RuleFor(x=>x.Name).NotEqual
        }
    }
}
