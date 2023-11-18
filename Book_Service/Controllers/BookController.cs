using Book_Service.DTO;
using Book_Service.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private CommonResponse _response;
        public BookController()
        {
            _response = new CommonResponse();
        }
        [HttpGet]
        //[Route("books")]
        public CommonResponse getBook()
        {
            _response.Result = new Book{ BookId=1, CreatedAt=DateTime.Now, Name="The Book" };
            return _response;
        }
    }
}
