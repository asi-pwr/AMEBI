using System;
using AMEBI.Domain.Model;

namespace AMEBI.Domain.Services
{
    public interface IJwtService
    {
        JwtToken CreateToken(Guid userId, string role);  
    }
}