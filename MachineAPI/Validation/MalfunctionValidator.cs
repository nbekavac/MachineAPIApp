using FluentValidation;
using DataAcces.Models;
using FluentValidation.AspNetCore;


namespace MachineAPI.Validation
{
    public class MalfunctionValidator:AbstractValidator<MalfunctionModel>
    {
        public MalfunctionValidator() 
        {
            RuleFor(x=>x.Description).NotEmpty();
            
            //Rule for Active Malfunction missing
        }
    }
}
