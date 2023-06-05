using System.Collections.Generic;
using Zoo.Roles.Dto;

namespace Zoo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
