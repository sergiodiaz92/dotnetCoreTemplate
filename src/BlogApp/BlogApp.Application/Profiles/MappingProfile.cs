using AutoMapper;
using BlogApp.Application.DTOs;
using BlogApp.Domain.Entities;

namespace BlogApp.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Post
            CreateMap<PostDTO, Post>().ReverseMap();
            #endregion
        }
    }
}
