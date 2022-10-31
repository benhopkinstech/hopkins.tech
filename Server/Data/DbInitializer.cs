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

            context.About.Add(new AboutData { Id = new Guid(), About = "<div>I am Ben Hopkins, a software engineer who is based in Wolverhampton, United Kingdom currently working for <a href=\"https://vigosoftware.com/\" target=\"_blank\">Vigo Software</a>.</div><br /><div>Technology has interested me from a young age and I spend as much time as I can trying to learn new things. I really enjoy creating software that solves problems, whether this be for work or just personal projects. Most of my current knowledge didn't actually come from educational institutions but from personal research and physically doing things. With the internet, information has never been so accessible and I believe you can teach yourself anything you put your mind to.</div><br /><div>However, I do have a degree in Computing & IT and Mathematics from studying at The Open University alongside full-time work. My journey within the software industry is just beginning and I am lucky that my current job allows me to work with a bunch of different technologies, which is really helping me to grow my skillset. Seeing software that I have written actually being used by people is something that is very rewarding.</div><br /><div>This website will be used to showcase my journey, things that I have worked on and experience that I have.</div><br /><div>Below are some things that I have experience with to date.</div><br /><div class=\"row\"><div class=\"col-3\"><ul><li>HTML</li><li>CSS</li><li>JavaScript</li><li>jQuery</li><li>React</li><li>Blazor</li><li>Bootstrap</li></ul></div><div class=\"col-3\"><ul><li>.NET</li><li>Docker</li><li>Kubernetes</li><li>Git</li><li>SQL</li><li>Auth0</li><li>APIs</li></ul></div><div class=\"col-6\"><ul><li>C#</li><li>WinForms</li><li>DevExpress</li><li>Windows Services</li><li>Scheduled Tasks</li><li>Azure DevOps</li><li>Entity Framework</li></ul></div></div>", });
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