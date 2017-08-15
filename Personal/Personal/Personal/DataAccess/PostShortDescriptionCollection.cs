using System;
using System.Collections.Generic;
using System.Linq;
using Personal.Models;

namespace Personal.DataAccess
{
    public class PostShortDescriptionCollection
    {
        private static readonly List<PostShortDescription> PostShortDescriptions;

        static PostShortDescriptionCollection()
        {
            PostShortDescriptions = new List<PostShortDescription>
            {
                new PostShortDescription(1, "dynamic dbContext with EF", "What if you would like to use EF and resolve object types at the runtime.", "~/Views/BlogPosts/DiAndMultipleImplementation.cshtml"),
                new PostShortDescription(2, "DI and multi-implementation of one interface", "How to get specific implementation dynamically knowing only a type.", "~/Views/BlogPosts/DynamicDbContext.cshtml")
            };
        }

        public List<PostShortDescription> GetAll()
        {
            return PostShortDescriptions;
        }

        public PostShortDescription GetById(int id)
        {
            return PostShortDescriptions.First(x => x.ID == id);
        }
        
    }
}