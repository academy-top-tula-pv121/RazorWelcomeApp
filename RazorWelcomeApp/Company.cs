namespace RazorWelcomeApp
{
    public class Company
    {
        public string Title { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"Company {Title} in {City}";
        }
    }
}
