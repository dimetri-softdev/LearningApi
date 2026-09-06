using Microsoft.AspNetCore.Mvc;

namespace LearningApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Topic>> GetTopics()
        {
            var topics = new List<Topic>
            {
                new Topic { Id = 1, Title = "ASP.NET Core Web API", Description = "Build scalable backend services using C# and .NET." },
                new Topic { Id = 2, Title = "Android Development", Description = "Create native mobile apps using Kotlin." },
                new Topic { Id = 3, Title = "RESTful APIs", Description = "Understand HTTP methods, endpoints, and JSON serialization." },
                new Topic { Id = 4, Title = "Retrofit", Description = "A type-safe HTTP client for Android and Kotlin." },
                new Topic { Id = 5, Title = "RecyclerView", Description = "An efficient UI widget for displaying large data sets in Android." }
            };

            return Ok(topics);
        }
    }
}
