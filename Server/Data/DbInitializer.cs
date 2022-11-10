using hopkins.tech.Shared;
using static System.Net.WebRequestMethods;

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

            context.Blogs.Add(new BlogData { Id = new Guid(), Url = "my-first-blog-post", Posted = new DateTime(2022, 11, 01), Title = "My first blog post", Summary = "An introduction to myself and the blog", Post = "<div>I am Ben Hopkins, a software engineer who is based in Wolverhampton, United Kingdom currently working for <a href=\"https://vigosoftware.com/\" target=\"_blank\">Vigo Software</a>.</div><br /><div>At the time of writing this post I am 24 years old and have been writing code on and off for the past 10 years of my life. Technology has interested me from a young age and I spend as much time as I can trying to learn new things. Currently, my strongest programming language is C# and this is one of the languages I am going to try and specialize my knowledge in.</div><br /><div>Most of the things I know currently didn't come from educational institutions but from personal research and physically doing things. With the internet, information has never been so accessible and I believe you can teach yourself anything you put your mind to. However, I have been studying a BSc in Computing & IT and Mathematics for the past 6 years at The Open University alongside full-time work and due to graduate next year.</div><br /><div>My journey within the software industry is just starting and I am lucky that my current job allows me to work with a bunch of different technologies, which is really helping me to grow my skillset. Seeing software that I have written being used by people is something that is very rewarding. One of my main goals is to write some software that really makes an impact and I am determined to acheive this whether this be through my career or my own projects.</div><br /><div>The main reason behind creating this blog is to document my journey by sharing what I am working on and things that I have experienced. Writing is not my strongest point, but this is something I will be able to develop as I write more posts. I have a desire to learn, educate and inspire others and I want to attempt to fulfil that through this medium. You can expect content predominantly based around software and technology but you might see some posts about other interests I have every now and then.</div><br /><div>Thanks for reading and I hope to see you again.</div>" });
            context.SaveChanges();
        }
    }
}