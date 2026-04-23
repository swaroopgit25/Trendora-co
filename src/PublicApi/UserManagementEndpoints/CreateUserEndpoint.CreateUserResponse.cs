using System;

namespace Trendora.PublicApi.UserManagementEndpoints;

public class CreateUserResponse : BaseResponse
{
    public CreateUserResponse(Guid correlationId)
    {

    }
    public CreateUserResponse() { }

    public string UserId { get; set; }

}

