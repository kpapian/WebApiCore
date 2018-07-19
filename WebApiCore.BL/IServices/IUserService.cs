using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCore.BL.Models;

namespace WebApiCore.BL.IServices
{
    public interface IUserService
    {
        /// <summary>
        /// Gets collection of UserDto
        /// </summary>
        /// <returns>UserDto collection</returns>
        Task<IEnumerable<UserDto>> GetUsersData();

        /// <summary>
        /// Gets collection of UserDto by userName
        /// </summary>
        /// <param name="userName">Searching param</param>
        /// <returns>UserDto model</returns>
        Task<UserDto> GetUserByUserName(string userName);

        /// <summary>
        /// Add new row to UserData table
        /// </summary>
        /// <param name="userDataDto">UserDataDto model</param>
        /// <returns>Returns task</returns>
        Task<UserDataDto> AddUserData(UserDataDto userDataDto);

        /// <summary>
        /// Update existing row/rows by UserId
        /// </summary>
        /// <param name="userData">UserDataDto model with needed userId</param>
        /// <returns>Returns task</returns>
        Task<IEnumerable<UserDataDto>> UpdateUserDataByUserId(UserDataDto userData);

        /// <summary>
        /// Delete existing row from USerData table by userId
        /// </summary>
        /// <param name="userId">UserId param for deleting specific row/rows</param>
        /// <returns>Returns task</returns>
        Task DeleteUserDataByUserId(int userId);
    }
}