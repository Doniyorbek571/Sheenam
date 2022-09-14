//====================================
//Copyright (c) Coalition of Doog-Hearted Engineers
//Free to Use Comfort and Peace
//====================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
             Ok("Hello Mario, the Footballer of another team");
    }
}
