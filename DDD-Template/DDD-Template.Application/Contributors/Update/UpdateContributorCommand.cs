using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DDD_Template.Application.Contributors.Update
{
    public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
}
