using AutoMapper;
using ITalent_Quiz2.Models;

namespace ITalent_Quiz2.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Post, PostCreateViewModel>().ReverseMap();
            CreateMap<Post, IndexPostViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();

        }




    }
}
