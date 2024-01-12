using System.ComponentModel.DataAnnotations;

namespace DDD_Template.Contributors.Create
{

    public class CreateContributorRequest
    {
        public const string Route = "/Contributors";

        [Required]
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
