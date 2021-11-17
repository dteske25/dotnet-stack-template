namespace DotnetStack.Core.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
