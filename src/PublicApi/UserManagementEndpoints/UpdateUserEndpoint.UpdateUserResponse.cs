using System;
using Trendora.Infrastructure.Identity;

namespace Trendora.PublicApi.UserManagementEndpoints;

public class UpdateUserResponse : BaseResponse
{
    public UpdateUserResponse(Guid correlationId) : base(correlationId)
    {
    }

    public UpdateUserResponse()
    {
    }
    public ApplicationUser User { get; set; }
}

