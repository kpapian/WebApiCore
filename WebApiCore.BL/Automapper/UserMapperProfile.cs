using AutoMapper;
using WebApiCore.BL.Models;
using WebApiCore.Dal.DataModel;
using System.Linq;

namespace WebApiCore.BL.Automapper
{
    /// <summary>
    /// User automaper class
    /// </summary>
    public class UserMapperProfile : Profile
    {
        /// <summary>
        /// Initialize instance of UserMapperProfile
        /// </summary>
        public UserMapperProfile()
        {
            //from user to UserDto
            this.CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.Id,//map userDto Id from user Id
                           userDto => userDto.MapFrom(user => user.Id))
                .ForMember(userDto => userDto.Name,
                           userDto => userDto.MapFrom(user => user.Name))
                .ForMember(userDto => userDto.UserText,
                           userDto => userDto.MapFrom(user => user.UserData.Select(data => data.UserText).ToList()))
                .ForMember(userDto => userDto.Role,
                           userDto => userDto.MapFrom(user => user.Role.Type))
                .ReverseMap();
        }
    }
}
