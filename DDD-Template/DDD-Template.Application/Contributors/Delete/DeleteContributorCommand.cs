using Ardalis.Result;
using Ardalis.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Template.Application.Contributors.Delete
{
    public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
}
