using hopkins.tech.Shared;

namespace hopkins.tech.Server.Data
{
    public class DbInitializer
    {
        public static void Initialize(HopkinsTechContext context)
        {
            context.Database.EnsureCreated();

            if (context.Blogs.Any())
            {
                return;
            }

            var blogs = new BlogData[]
            {
                new BlogData { Url = "test-title", Posted = DateTime.Now, Title = "Test Title", Summary = "This is a short summary for my test", Post = "<h1>Testing Heading 1</h1><h2>Testing Heading 2</h2>Some content of the blog post" },
            };
            
            foreach (BlogData b in blogs)
            {
                context.Blogs.Add(b);
            }
            context.SaveChanges();
        }
    }
}