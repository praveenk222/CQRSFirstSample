using System;
using System.Collections.Generic;

namespace Persistence.Models;

public partial class UserToken
{
    public int TokenId { get; set; }

    public string UserId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? IssuedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public bool? IsRevoked { get; set; }

    public DateTime? RevokedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }
}
