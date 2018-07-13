using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebApiCore.Dal.DataModel
{
    /// <summary>
    ///  Describes User entity
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets id in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Name in the database
        /// </summary>
        [Required]
        public string Name { get; set; }

        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets Role in the database
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Navigation property of type ICollection UserData
        /// </summary>               
        public ICollection<UserData> UserData { get; set; }
    }
}
