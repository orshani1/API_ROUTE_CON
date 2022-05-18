using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ROUTEHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:min(5)}")]
        public string GetById()
        {
            return "Hello From Id min 5";
        }

        [Route("{id:alpha}")]
        public string GetByAlphaId()
        {
            return "Hello From Alpha id , Dont know to do the ragex ... ";
        }
    }
}
