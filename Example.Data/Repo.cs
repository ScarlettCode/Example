using System.Linq;
using static Example.Data.ExampleContext;

namespace Example.Data
{
    public class Repo
    {
        public string Get()
        {
            using (var db = new ExampleContext())
            {
                db.Blogs.Add(new Blog { Url = "https://www.hanselman.com/blog/HowToReferenceANETCoreLibraryInWinFormsOrNETStandardExplained.aspx" });
                db.SaveChanges();
            }

            using (var db = new ExampleContext())
            {
                return db.Blogs.First().Url;
            }
        }
    }
}
