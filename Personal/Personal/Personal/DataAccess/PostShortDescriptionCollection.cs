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
                new PostShortDescription(2, "Dependency injection and custom dynamic type parsers - part 2",
                                         "Generic types are very powerful and easy to use, especially when you use them with parsing mechanism. " +
                                         "Due to that you can immediately with simply taking a quick peek at the code, know exactly what the returning type will be." +
                                         "<br/>There is one issue though, what if we don't know the returning type during the compilation time? " +
                                         "<br/>Of course I believe everyone was in that kind of situation and they somehow managed to solve it. I had that issue too and I came up with some solution I haven't seen anywhere, so I decided to share that with you. " +
                                         "<br/>Hopefully you are going to like it and find it usefull in your projects as much as I find it in mine.",
                                         "~/Views/BlogPosts/0002_DI_DynamicCustomTypeConverter.cshtml"),
                new PostShortDescription(1, "Dependency injection and custom generic type parsers - part 1",
                                         "Lets think of a situation where you want to use some generic common mechanism for all your types to be parsed - that should be quite easy shouldn't it?" +
                                         " But what if you would like to add custom behaviour for some of types and you really don't want to write the logic for all of them, because in most cases you still can use the generic solution." +
                                         "<br/>Yes of course there are plenty of solutions for that kind of scenario but it will be nice to keep it clear without breaking any SOLID principle e.g. creating huge SWITCH statement for all of defined types." +
                                         "<br/>And in that kind of scenario dependency injection container can be amazingly helpful.",
                                         "~/Views/BlogPosts/0001_DI_GenericCustomTypeConverter.cshtml"),
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