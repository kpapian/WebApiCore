using System;
using System.Collections.Generic;
using System.Text;
using WebApiCore.BL.Models;
using WebApiCore.Dal.DataModel;

namespace WebApiCore.BL.Mappers
{
    /// <summary>
    /// Contains information of the mapping user data entities
    /// </summary>
    public static class UserDataMapper
    {
        /// <summary>
        /// Extension method for mapping UserDataDto model to UserData
        /// </summary>
        /// <param name="userDataDto">Takes DTO model</param>
        /// <returns>Returns entity model</returns>
        public static UserData ToUserData(this UserDataDto userDataDto)
        {
            if (userDataDto == null)
            {
                return null;
            }

            UserData userData = new UserData
            {
                UserId = userDataDto.UserId,
                UserText = userDataDto.UserText
            };

            return userData;
        }
    }
}
