using System;
using System.Collections.Generic;
using Trendora.Infrastructure.Identity;

namespace Trendora.PublicApi.RoleMembershipEndpoints;

public class GetRoleMembershipResponse : BaseResponse
{

    public GetRoleMembershipResponse(Guid correlationId) : base(correlationId)
    {
    }

    public GetRoleMembershipResponse()
    {
    }

    public List<ApplicationUser> RoleMembers { get; set; }
}

