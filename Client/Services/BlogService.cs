using BlazorAppBlog1.Shared;

namespace BlazorAppBlog1.Client.Services
{
    public class BlogService : IBlogService
    {
        public BlogPost GetBlogPostByUrl(string url)
        {
        
            return Posts.FirstOrDefault(p=>p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
