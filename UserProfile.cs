using AutoMapper;
using AutoMapperApp.Models;
using AutoMapperApp.ViewModel;

namespace AutoMapperApp
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.FName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest =>
                dest.LName,
                opt => opt.MapFrom(src => src.LastName));
        }
    }
}
