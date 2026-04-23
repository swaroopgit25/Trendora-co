using System;

namespace Trendora.PublicApi.UserManagementEndpoints.Models;

public class GetUserResponse : BaseResponse
{

    public GetUserResponse(Guid correlationId) : base(correlationId)
    {
    }

    public GetUserResponse()
    {
    }

    public UserDto User { get; set; }
}

