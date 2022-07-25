using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppBlog1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogControler : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
         {
        new BlogPost { Url="new-tutorial", Title = "stuff about blazor with Web API", Description= "This is ...text", Content="iaondazincoarcoaeca aoziucnazc azoecnazep caecapez caozuepazpicuzan cazeacnpzejiapozeuncpaziecjeluuezpzae  aeuc azecazijcamzeice"},
        new BlogPost { Url="first-post", Title ="More stuff about Blazor with Web API", Description ="hi, this is a blogpost", Content=" cziacnzaoircnozae ozaeicazpoicnazoiec azoeic azeoic azire,cpoazicnazirnvpaozekcciznaozricnzapocnairjvn aerk, âir îzaecarznaoicnezoiazc azoicnaôrienc^zaeinmirnvnpzaocnazisinvir,zzaifroza,cirea"}
        };

        public ActionResult<List<BlogPost>> GimmeAllTheBlogPosts()
        {
            return Ok(Posts);
        }
        public ActionResult<BlogPosts> 
    }
}
