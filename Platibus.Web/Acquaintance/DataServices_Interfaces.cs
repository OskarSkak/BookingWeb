

using Platibus.Web.DataServices.Models.User;
using Platibus.Web.Documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Platibus.Web.Acquaintance.IDataServices
{
    public interface IUserDataService
    {
        Task<Response> CreateUser(IUser user);
        Task<User> GetUserById(Guid id);
        /// <summary>
        /// Returns a single page from the list of users.
        /// </summary>
        /// <param name="page">The page index to be shown from the list.</param>
        /// <param name="pageSize">The size of each page.</param>
        /// <returns>A list of users on the specific page.</returns>
        Task<IEnumerable<User>> ListUsersAsync(int page, int pageSize);

    }

    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
    
    



}