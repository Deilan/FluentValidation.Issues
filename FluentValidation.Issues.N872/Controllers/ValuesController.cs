using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation.Issues.N872.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(GetQuery query)
        {
            return new[] { "value1", "value2" };
        }
    }

    public class GetQuery
    {
    }
}
