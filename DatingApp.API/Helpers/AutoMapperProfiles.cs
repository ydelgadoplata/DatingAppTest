using System;
using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoURL, opt
            => opt.MapFrom(src
            => src.Photos.FirstOrDefault(p
            => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt 
            => opt.MapFrom(src 
            => src.DateOfBirth.AgeCalc()));

            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoURL, opt
            => opt.MapFrom(src
            => src.Photos.FirstOrDefault(p
            => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt 
            => opt.MapFrom(src 
            => src.DateOfBirth.AgeCalc()));

            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
        }

    }
}