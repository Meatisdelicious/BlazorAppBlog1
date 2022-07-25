using BlazorAppBlog1.Shared;
using System.Threading.Tasks;


namespace BlazorAppBlog1.Client.Services
{
    interface IBlogService
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<BlogPost> GetBlogPostByUrl(string url);
    }
}
