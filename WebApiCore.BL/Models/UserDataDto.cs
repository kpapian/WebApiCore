using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCore.BL.Models
{
    /// <summary>
    /// Contains information of UserData Dto
    /// </summary>
    public class UserDataDto
    {
        /// <summary>
        /// Gets or sets the Id of UserData Dto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the UserText of UserData Dto
        /// </summary>
        public string UserText { get; set; }

        /// <summary>
        /// Gets or sets the UserId of UserData Dto
        /// </summary>
        public int UserId { get; set; }
    }
}
