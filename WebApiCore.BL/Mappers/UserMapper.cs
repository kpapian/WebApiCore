using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WebApiCore.BL.Models;
using WebApiCore.Dal.DataModel;

namespace WebApiCore.BL.Mappers
{
    /// <summary>
    /// Contains information of the mapping user entities
    /// </summary>
    public static class UserMapper
    {
        /// <summary>
        /// Extension method for mapping User model to UserDto
        /// </summary>
        /// <param name="user">Takes entity model</param>
        /// <returns>Returns User Dto model</returns>
        public static UserDto ToUserDto(this User user)
        {
            if (user == null)
            {
                return null;
            }

            UserDto userDto = new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                UserText = user.UserData.Select(data => data.UserText).ToList(),
                Role = user.Role.Type
            };

            return userDto;
        }

        /// <summary>
        /// Extension method for mapping UserDto model to User entity
        /// </summary>
        /// <param name="userDto">Takes Dto model</param>
        /// <returns>Returns User model entity</returns>
        public static User ToUser(this UserDto userDto)
        {
            if (userDto == null)
            {
                return null;
            }

            User user = new User
            {
                Id = userDto.Id,
                Name = userDto.Name,
                Role = new Role { Type = userDto.Role }
            };

            return user;
        }

        /// <summary>
        /// Extension method for mapping collection of Users entity to UserDto models
        /// </summary>
        /// <param name="userList">Takes list of Users entity</param>
        /// <returns>Returns collection of UserDTOs</returns>
        public static ICollection<UserDto> ToUserDTOList(this List<User> userList)
        {
            ICollection<UserDto> userDtoList = new List<UserDto>();

            foreach (User user in userList)
            {
                userDtoList.Add(ToUserDto(user));
            }

            return userDtoList;
        }
    }
}
