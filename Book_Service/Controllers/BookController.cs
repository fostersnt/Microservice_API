using AutoMapper;
using Book_Service.DTO;
using Book_Service.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Service.Controllers
{
    //[Route("api/[controller]")]
    [Route("microservice/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly CommonResponse _response;
        private readonly IMapper _mapper;
        public BookController(IMapper mapper)
        {
            _response = new CommonResponse();
            _mapper = mapper;
        }
        [HttpGet]
        //[Route("books")]
        public CommonResponse get()
        {
            Book book = new Book { BookId = 1, CreatedAt = DateTime.Now, Name = "The Book" };
            //return _response;
            var bookMapper = _mapper.Map<BookDTO>(book);
            _response.Result = bookMapper;
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public CommonResponse get(int id)
        {
            _response.Result = null;
            return _response;
        }
    }
}
