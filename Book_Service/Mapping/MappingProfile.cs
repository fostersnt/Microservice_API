using AutoMapper;
using Book_Service.DTO;
using Book_Service.Model;

namespace Book_Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>();
        }
    }
}
