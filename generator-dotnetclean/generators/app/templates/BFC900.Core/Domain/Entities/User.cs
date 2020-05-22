// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Represents a user across the system.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Domain.Entities
{
    /// <summary>
    /// Represents a user across the system.
    /// </summary>
    public class User : BaseEntity<int>
    {
        /// <summary>
        /// Gets or sets the full user name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets user the nick name.
        /// </summary>
        public string NickName { get; set; }
    }
}