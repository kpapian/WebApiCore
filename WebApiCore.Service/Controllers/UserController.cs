using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.BL.Services;
using WebApiCore.BL.Models;

namespace WebApiCore.Service.Controllers
{
    /// <summary>
    /// Class for working with users and users data end points
    /// </summary>
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Instance of UserService class
        /// </summary>
        private UserService userService = new UserService();

        /// <summary>
        /// Gets list of existing users and their info
        /// </summary>
        /// <returns>Task of IHttpActionResult type</returns>
        //[BasicAuthorization("admin", "user")]
        public async Task<IActionResult> GetUserInfoList()
        {
            var userList = await this.userService.GetUsersData();

            if (userList == null)
            {
                return this.NotFound();
            }

            return this.Ok(userList);
        }

        /// <summary>
        /// Gets user info by passing user name
        /// </summary>
        /// <param name="userName">Passing parametr</param>
        /// <returns>Task of IHttpActionResult type</returns>
        [HttpGet("{userName}")]
        public async Task<IActionResult> GetUserInfoByUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return this.BadRequest();
            }

            var user = await this.userService.GetUserByUserName(userName);

            if (user == null)
            {
                return this.NotFound();
            }

            return this.Ok(user);
        }

        /// <summary>
        /// Posts new data to UserData table
        /// </summary>
        /// <param name="userDataDto">Passing data will be added to UserData table</param>
        /// <returns>Task of IHttpActionResult type</returns>
        [HttpPost]
        public async Task<IActionResult> PostUserInfo([FromBody] UserDataDto userDataDto)
        {
            if (userDataDto == null)
            {
                return this.BadRequest();
            }

            await this.userService.AddUserData(userDataDto);

            return this.Ok();
        }

        /// <summary>
        /// Update existing user data by user Id
        /// </summary>
        /// <param name="userData">Passing model for updating existing data</param>
        /// <returns>Task of IHttpActionResult type</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateUserInfoByUserId([FromBody] UserDataDto userData)
        {
            if (userData == null)
            {
                return this.BadRequest();
            }

            await this.userService.UpdateUserDataByUserId(userData);

            return this.Ok();
        }

        /// <summary>
        /// Delete user data by user id from UserData table
        /// </summary>
        /// <param name="userId">Allows find user data which will be deleted</param>
        /// <returns>Task of IHttpActionResult type</returns>
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUserInfoByUserId(int userId)
        {
            if (userId == 0)
            {
                return this.BadRequest();
            }

            await this.userService.DeleteUserDataByUserId(userId);

            return this.Ok();
        }
    }
}