using BlazorAppBlog1.Shared;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorAppBlog1.Client.Services
{
    public class BlogService : IBlogService
    {
        public readonly HttpClient _http;

        public BlogService(HttpClient http)
        {
            _http = http;
        }
        
        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var post = await _http.GetFromJsonAsync<BlogPost>($"api/Blog/{url}");
            return post;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>("api/Blog");
            //also implement this part in a part of the interface
        }
    }
}
