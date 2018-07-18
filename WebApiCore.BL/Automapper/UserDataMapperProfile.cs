using AutoMapper;
using WebApiCore.BL.Models;
using WebApiCore.Dal.DataModel;

namespace WebApiCore.BL.Automapper
{
    /// <summary>
    /// UserData automaper class
    /// </summary>
    public class UserDataMapperProfile : Profile
    {
        /// <summary>
        /// Initialize instance of UserDataMapperProfile
        /// </summary>
        public UserDataMapperProfile()
        {
            //from userDataDto to UserData
            this.CreateMap<UserDataDto,UserData>()
                .ForMember(userData => userData.UserId,//map userData Id from userDataDto Id
                           userData => userData.MapFrom(userDataDto => userDataDto.UserId))
                .ForMember(userData => userData.UserText,
                           userData => userData.MapFrom(userDataDto => userDataDto.UserText))
                .ReverseMap();
        }
    }
}
