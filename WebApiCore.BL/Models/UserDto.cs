using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCore.BL.Models
{
    /// <summary>
    /// Contains information of UserDto model
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets the Id of User Dto model
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of User Dto model
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the UserText of User Dto model
        /// </summary>
        public ICollection<string> UserText { get; set; }

        /// <summary>
        /// Gets or sets the Role of User Dto model
        /// </summary>
        public string Role { get; set; }
    }
}
