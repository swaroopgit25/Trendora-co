using System;
using Microsoft.AspNetCore.Identity;

namespace Trendora.PublicApi.RoleManagementEndpoints;

public class CreateRoleResponse : BaseResponse
{
    public CreateRoleResponse(Guid correlationId)
    {

    }
    public CreateRoleResponse() { }

    public IdentityRole Role { get; set; }
}

