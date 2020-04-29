using Microsoft.AspNetCore.Mvc;

namespace fakeApi.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class FakeController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Anrop till Fake Repo
            return "Hi there";
        }
    }
}