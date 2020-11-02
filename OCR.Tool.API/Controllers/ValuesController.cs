using Microsoft.AspNetCore.Mvc;

namespace OCR.Tool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("test")]
        public JsonResult test()
        {
            return new JsonResult("sd");
        }
    }
}