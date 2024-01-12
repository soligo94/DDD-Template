using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DDD_Template.Application.Contributors.List
{
    public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
}
