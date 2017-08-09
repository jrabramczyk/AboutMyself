namespace Personal.Models
{
    public class PostShortDescription
    {
        public PostShortDescription(string title, string description, string partialViewName)
        {
            Title = title;
            Description = description;
            PartialViewName = partialViewName;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string PartialViewName { get; }
    }
}