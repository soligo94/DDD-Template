using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DDD_Template.Application.Contributors.Get
{
    public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
}
