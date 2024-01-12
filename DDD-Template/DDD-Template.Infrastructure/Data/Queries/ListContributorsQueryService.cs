using DDD_Template.Application.Contributors;
using DDD_Template.Application.Contributors.List;
using Microsoft.EntityFrameworkCore;

namespace DDD_Template.Infrastructure.Data.Queries
{
    public class ListContributorsQueryService(AppDbContext _db) : IListContributorsQueryService
    {
        // You can use EF, Dapper, SqlClient, etc. for queries - this is just an example
        public async Task<IEnumerable<ContributorDTO>> ListAsync()
        {
            // NOTE: This will fail if testing with EF InMemory provider
            var result = await _db.Database.SqlQuery<ContributorDTO>(
              $"SELECT Id, Name, PhoneNumber_Number FROM Contributors") // don't fetch other big columns
                                                                        //.Select(c => new ContributorDTO(c.Id, c.Name, c.PhoneNumber?.Number ?? ""))
              .ToListAsync();

            return result;
        }
    }
}
