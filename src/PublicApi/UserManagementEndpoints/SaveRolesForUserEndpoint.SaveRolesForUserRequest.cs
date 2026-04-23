using System.Collections.Generic;

namespace Trendora.PublicApi.UserManagementEndpoints;

public class SaveRolesForUserRequest : BaseRequest
{
    public string UserId { get; set; }
    public List<string> RolesToAdd { get; set; } = [];
    public List<string> RolesToRemove { get; set; } = [];
}

