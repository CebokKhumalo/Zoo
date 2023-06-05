using System.Collections.Generic;
using Zoo.Roles.Dto;

namespace Zoo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
