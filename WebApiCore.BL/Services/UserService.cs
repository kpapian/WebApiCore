﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCore.BL.Models;
using WebApiCore.Dal.DataContext;
using WebApiCore.Dal.DataModel;
using WebApiCore.BL.IServices;
using AutoMapper;

namespace WebApiCore.BL.Services
{

    /// <summary>
    /// Contains information of basic CRUD operations with User and UserData entities
    /// </summary>
    internal sealed class UserService : IUserService
    {
        /// <summary>
        /// Instance of UserContext for manipulation with DataBase
        /// </summary>
        private readonly UserContext db;

        /// <summary>
        /// Instance of IMapper
        /// </summary>
        private readonly IMapper autoMapper;

        /// <summary>
        /// Initialize a nw instance of UserService
        /// </summary>
        /// <param name="db"> UserContext type param </param>
        public UserService(UserContext db, IMapper mapper)
        {
            this.db = db;
            this.autoMapper = mapper;
        }

        /// <summary>
        /// Gets collection of UserDto
        /// </summary>
        /// <returns>UserDto collection</returns>
        public async Task<IEnumerable<UserDto>> GetUsersData()
        {
            var userList = await this.db.Users
                                  .Include(user => user.UserData)
                                  .Include(user => user.Role)
                                  .ToArrayAsync();

            var userDtoList = userList.Select(user => this.autoMapper.Map<UserDto>(user));

            return userDtoList;
        }

        /// <summary>
        /// Gets collection of UserDto by userName
        /// </summary>
        /// <param name="userName">Searching param</param>
        /// <returns>UserDto model</returns>
        public async Task<UserDto> GetUserByUserName(string userName)
        {
            var user = await this.db.Users
                                  .Include(u => u.UserData)
                                  .Include(u => u.Role)
                                  .FirstOrDefaultAsync(u => u.Name == userName);

            var userDto = this.autoMapper.Map<UserDto>(user);

            return userDto;
        }

        /// <summary>
        /// Add new row to UserData table
        /// </summary>
        /// <param name="userDataDto">UserDataDto model</param>
        /// <returns>Returns task</returns>
        public async Task<UserDataDto> AddUserData(UserDataDto userDataDto)
        {
            this.db.UserData.Add(this.autoMapper.Map<UserData>(userDataDto));

            await this.db.SaveChangesAsync();

            var addedUserData = this.db.UserData
                                    .Include(user => user.User)
                                    .Where(userData => userData.UserText.Equals(userDataDto.UserText)).FirstOrDefault();

            return this.autoMapper.Map<UserDataDto>(addedUserData);
        }

        /// <summary>
        /// Update existing row/rows by UserId
        /// </summary>
        /// <param name="userData">UserDataDto model with needed userId</param>
        /// <returns>Returns task</returns>
        public async Task<IEnumerable<UserDataDto>> UpdateUserDataByUserId(UserDataDto userData)
        {
            IEnumerable<UserData> userDataList = new List<UserData>();

            if (userData.UserId != 0)
            {
                userDataList = await this.db.UserData
                                       .Where(u => u.User.Id.Equals(userData.UserId))
                                       .ToListAsync();
            }

            foreach (var row in userDataList)
            {
                row.UserText = userData.UserText;
            }

            await this.db.SaveChangesAsync();

            ICollection<UserDataDto> updatedUserDataList = new List<UserDataDto>();

            foreach (var row in userDataList)
            {
                updatedUserDataList.Add(this.autoMapper.Map<UserDataDto>(row));
            }

            return updatedUserDataList;
        }

        /// <summary>
        /// Delete existing row from USerData table by userId
        /// </summary>
        /// <param name="userId">UserId param for deleting specific row/rows</param>
        /// <returns>Returns task</returns>
        public async Task DeleteUserDataByUserId(int userId)
        {
            var userDataList = await this.db.UserData
                                      .Where(u => u.User.Id.Equals(userId))
                                      .ToArrayAsync();

            foreach (var userData in userDataList)
            {
                this.db.UserData.Remove(userData);
            }

            await this.db.SaveChangesAsync();
        }
    }
}
