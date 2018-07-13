using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApiCore.Dal.DataModel
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Describes UserData entity
    /// </summary>
    [Table("UserData")]
    public class UserData
    {
        /// <summary>
        /// Gets or sets id in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets UserText in the database
        /// </summary>
        public string UserText { get; set; }

        /// <summary>
        /// Gets or sets UserId in the database
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Reference navigation property of User class
        /// </summary>
        public User User { get; set; }
    }
}
