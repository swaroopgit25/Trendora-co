using System;
using Microsoft.AspNetCore.Identity;

namespace Trendora.PublicApi.RoleManagementEndpoints;

public class GetByIdRoleResponse : BaseResponse
{

    public GetByIdRoleResponse(Guid correlationId) : base(correlationId)
    {
    }

    public GetByIdRoleResponse()
    {
    }

    public IdentityRole Role { get; set; }
}

