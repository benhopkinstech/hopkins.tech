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

            var blogs = new BlogData[]
            {
                new BlogData { Id = new Guid(), Url = "welcome-to-my-blog", Posted = new DateTime(2022,10,31), Title = "Welcome to my blog", Summary = "A short introduction to my blog", Post = "<div>My name is Ben Hopkins and at the time of writing this I am 24 years old. I am currently based in Wolverhampton, United Kingdom and started my career in the software industry in June 2022. I have been writing code on and off for the past 10 years of my life. Currently, my strongest programming language is C# and this is one of the languages I am going to try and specialize my knowledge in.</div><br /><div>The main reason behind creating this blog is to document my journey by sharing what I am working on and things that I have experienced. Writing is not my strongest point, but this is something I will be able to develop as I write more posts. I have a desire to learn, educate and inspire others and I want to attempt to fulfil that through this medium.</div><br /><div>You can expect content predominantly based around software and technology. However, you might see some posts about other interests I have every now and then.</div><br /><div>Thanks for reading and I hope to see you again.</div>" },
            };
            
            foreach (BlogData b in blogs)
            {
                context.Blogs.Add(b);
            }
            context.SaveChanges();
        }
    }
}