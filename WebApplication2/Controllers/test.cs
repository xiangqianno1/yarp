using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{

    [DynamicApiController]
    public class test
    {
        [HttpGet]
        public string GetName()
        {
            return "furion";
        }
    }
}
