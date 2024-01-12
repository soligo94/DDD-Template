namespace DDD_Template.Contributors.Create
{
    public class CreateContributorResponse(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
