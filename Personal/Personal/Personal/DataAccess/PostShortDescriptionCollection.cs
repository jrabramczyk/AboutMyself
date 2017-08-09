using System.Collections.Generic;
using Personal.Models;

namespace Personal.DataAccess
{
    public class PostShortDescriptionCollection
    {
        private static readonly List<PostShortDescription> _postShortDescriptions;

        public PostShortDescriptionCollection()
        {
            
        }

        static PostShortDescriptionCollection()
        {
            _postShortDescriptions = new List<PostShortDescription>
            {
                new PostShortDescription("dynamic dbContext with EF", "What if you would like to use EF and resolve object types at the runtime.", "~/Views/BlogPosts/DiAndMultipleImplementation.cshtml"),
                new PostShortDescription("DI and multi-implementation of one interface", "How to get specific implementation dynamically knowing only a type.", "~/Views/BlogPosts/DynamicDbContext.cshtml")
            };
        }

        public List<PostShortDescription> GetAll()
        {
            return _postShortDescriptions;
        }

    }
}