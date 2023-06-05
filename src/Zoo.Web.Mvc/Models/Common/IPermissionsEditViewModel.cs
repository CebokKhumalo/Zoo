using System.Collections.Generic;
using Zoo.Roles.Dto;

namespace Zoo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}