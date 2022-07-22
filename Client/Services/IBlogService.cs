using BlazorAppBlog1.Shared;

namespace BlazorAppBlog1.Client.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);
    }
}
