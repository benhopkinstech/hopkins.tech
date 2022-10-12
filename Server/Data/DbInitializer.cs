using hopkins.tech.Shared;
using System;

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
                new BlogData { Url = "test-title", Posted = DateTime.Now, Title = "Test", Summary = "This is a short summary for my test", Post = "<h1>Test</h1><h2>Testing</h2>This is the content of the blog post" },
            };

            foreach (BlogData b in blogs)
            {
                context.Blogs.Add(b);
            }
            context.SaveChanges();
        }
    }
}