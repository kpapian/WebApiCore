using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCore.Dal.DataModel
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Describes Role entity
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Gets or sets id in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Type in the database
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets User collection from the database
        /// </summary>
        public ICollection<User> Users { get; set; }
    }
}
