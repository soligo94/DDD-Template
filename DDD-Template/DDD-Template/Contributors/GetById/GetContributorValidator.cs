using FastEndpoints;
using FluentValidation;

namespace DDD_Template.Contributors.GetById
{
    /// <summary>
    /// See: https://fast-endpoints.com/docs/validation
    /// </summary>
    public class GetContributorValidator : Validator<GetContributorByIdRequest>
    {
        public GetContributorValidator()
        {
            RuleFor(x => x.ContributorId)
              .GreaterThan(0);
        }
    }
}
