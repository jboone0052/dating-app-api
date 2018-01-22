using System.Linq;
using AutoMapper;
using dating_app_api.Dtos;
using dating_app_api.Models;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt => 
                {
                    opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<User, UserForDetailDto>()
                .ForMember(dest => dest.PhotoUrl, opt => 
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt => 
                {
                    opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<Photo, PhotosForDetailDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<MessageForCreationDto, Message>();
            CreateMap<Message, MessageForCreationDto>()
                .ForMember(dest => dest.SenderPhotoUrl, opt => {
                    opt.MapFrom(src => src.Sender.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.RecipientPhotoUrl, opt => {
                    opt.MapFrom(src => src.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
            CreateMap<Message, MessageForReturnDto>()
                .ForMember(dest => dest.SenderPhotoUrl, opt => {
                    opt.MapFrom(src => src.Sender.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.RecipientPhotoUrl, opt => {
                    opt.MapFrom(src => src.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
        }
    }
}