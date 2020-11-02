using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace OCR.Tool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="id">haooe</param>
        /// <returns></returns>
        [Route("test")]
        [HttpGet]
        [SwaggerOperation("test")]
        public JsonResult Test([FromQuery][Required] string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            return new JsonResult("sd");
        }
    }
}