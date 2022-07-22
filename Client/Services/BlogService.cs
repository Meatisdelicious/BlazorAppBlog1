using BlazorAppBlog1.Shared;

namespace BlazorAppBlog1.Client.Services
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>() 
         {
        new BlogPost { Url="new-tutorial", Title = "stuff about blazor", Description= "This is ...text"},
        new BlogPost { Url="first-post", Title ="More stuff about Blazor", Description ="hi, this is a blogpost"}
        };

        public BlogPost GetBlogPostByUrl(string url)
        {
            throw new NotImplementedException();
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
