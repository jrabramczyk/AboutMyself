namespace Personal.Models
{
    public class PostShortDescription
    {
        public PostShortDescription(int id, string title, string description, string partialViewName)
        {
            ID = id;
            Title = title;
            Description = description;
            PartialViewName = partialViewName;
        }

        public int ID { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PartialViewName { get; }
    }
}