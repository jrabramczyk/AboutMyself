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
                new PostShortDescription(3, "OrderBy().ThenBy()... vs OrderBy(x => new { ... }) fancy feature or hidden issue",
                                         "From all developers I know I'm nothing special in terms of feeling excitement when you find out new feature, framework or just in general brand new solution on well known problem. " +
                                         "Whenever I find something new I'm so eager to put it everywhere in the code so everyone can see it - did I mention I hate boring repetitive tasks ?!!! ... and yes that is one of them " +
                                         "but still that doesn't stop me from populating new solution across the whole project." +
                                         "<br/>I'm not really sure what psychological theory stand behind that behaviour but it's probably related to 'need of showing off', 'internal ego', 'desire of letting the world know how much do we actually know' " +
                                         "or maybe simply an willingness to tell the world there is something better out there that we can use - <span style=\"font-size: 14px\">nah I also don't think it's the last case</span>.",
                                         "~/Views/BlogPosts/0003_OrderByThenByVsOrderByAnonymous.cshtml"),
                new PostShortDescription(2, "Dependency injection and custom dynamic type parsers - part 2",
                                         "Generic types are very powerful and easy to use, especially when you use them with parsing mechanism. " +
                                         "Due to that you can immediately with simply taking a quick peek at the code, know exactly what the returning type will be." +
                                         "<br/>There is one issue though, what if we don't know the returning type during the compilation time? " +
                                         "<br/>Of course I believe everyone was in that kind of situation and they somehow managed to solve it. I had that issue too and I came up with some solution I haven't seen anywhere else, so I decided to share that with you. " +
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