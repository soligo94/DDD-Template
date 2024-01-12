namespace DDD_Template.Contributors.Update
{
    public class UpdateContributorResponse(ContributorRecord contributor)
    {
        public ContributorRecord Contributor { get; set; } = contributor;
    }
}
