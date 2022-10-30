using hopkins.tech.Shared;
using static System.Net.WebRequestMethods;

namespace hopkins.tech.Server.Data
{
    public class DbInitializer
    {
        public static void Initialize(HopkinsTechContext context)
        {
            context.Database.EnsureCreated();

            if (context.Index.Any())
            {
                return;
            }

            context.Index.Add(new IndexData { Id = new Guid(), Title = "Software Engineer", Tagline = "with a love for all things tech" });
            context.SaveChanges();

            var socialIcons = new SocialIcon[]
            {
                new SocialIcon { Id = new Guid(), Link = "https://github.com/benhopkinstech", Icon = "logos:github-icon", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://stackoverflow.com/users/5195787/benhopkinstech", Icon = "logos:stackoverflow-icon", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://hub.docker.com/u/benhopkinstech", Icon = "logos:docker-icon", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://www.nuget.org/profiles/benhopkinstech", Icon = "vscode-icons:file-type-nuget", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://www.linkedin.com/in/benhopkinstech/", Icon = "logos:linkedin-icon", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://www.youtube.com/channel/UCBS4y-oMVnON1ERYyZVP-OQ", Icon = "logos:youtube-icon", Width = 40, Height = 40, Colour = "" },
                new SocialIcon { Id = new Guid(), Link = "https://www.instagram.com/benhopkinstech/", Icon = "fa-brands:instagram-square", Width = 40, Height = 40, Colour = "#bc2a8d" },
                new SocialIcon { Id = new Guid(), Link = "https://twitter.com/benhopkinstech", Icon = "logos:twitter", Width = 40, Height = 40, Colour = "" },
            };

            foreach (SocialIcon icon in socialIcons)
            {
                context.SocialIcons.Add(icon);
            }
            context.SaveChanges();

            context.About.Add(new AboutData { Id = new Guid(), Summary = "", Education = "", Experience = "" });
            context.SaveChanges();

            var blogs = new BlogData[]
            {
                new BlogData { Id = new Guid(), Url = "test-title", Posted = DateTime.Now, Title = "Test Title", Summary = "This is a short summary for my test", Post = "<h1>Testing Heading 1</h1><h2>Testing Heading 2</h2>Some content of the blog post" },
            };
            
            foreach (BlogData b in blogs)
            {
                context.Blogs.Add(b);
            }
            context.SaveChanges();
        }
    }
}