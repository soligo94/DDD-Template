using DDD_Template.Application.Contributors;
using DDD_Template.Application.Contributors.List;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD_Template.Infrastructure.Data.Queries
{
    public class FakeListContributorsQueryService : IListContributorsQueryService
    {
        public Task<IEnumerable<ContributorDTO>> ListAsync()
        {
            List<ContributorDTO> result =
                [new ContributorDTO(1, "Fake Contributor 1", ""),
                    new ContributorDTO(2, "Fake Contributor 2", "")];

            return Task.FromResult(result.AsEnumerable());
        }
    }
}
