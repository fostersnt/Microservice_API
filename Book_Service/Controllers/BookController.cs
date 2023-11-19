﻿using AutoMapper;
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
        private readonly CommonResponse _response;
        private readonly IMapper _mapper;
        public BookController(IMapper mapper)
        {
            _response = new CommonResponse();
            _mapper = mapper;
        }
        [HttpGet]
        //[Route("books")]
        public IActionResult getBook()
        {
            Book book = new Book { BookId = 1, CreatedAt = DateTime.Now, Name = "The Book" };
            //_response.Result = new Book{ BookId=1, CreatedAt=DateTime.Now, Name="The Book" };
            //return _response;
            var bookMapper = _mapper.Map<BookDTO>(book);
            return Ok(bookMapper);
        }
    }
}